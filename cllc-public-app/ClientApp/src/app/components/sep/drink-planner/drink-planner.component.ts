import { Component, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { FormBase } from '@shared/form-base';
import { Subscription } from 'rxjs';
import { faLightbulb } from '@fortawesome/free-regular-svg-icons';
import configuration, { DrinkConfig, HOURS_OF_LIQUOR_SERVICE, SERVINGS_PER_PERSON } from './config';
import { SepApplication } from '@models/sep-application.model';
import { faQuestionCircle } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-drink-planner',
  templateUrl: './drink-planner.component.html',
  styleUrls: ['./drink-planner.component.scss'],
})
export class DrinkPlannerComponent extends FormBase implements OnInit {
  // icons
  faLightbulb = faLightbulb;
  faQuestionCircle = faQuestionCircle;
  totalServings = 0;
  _app: SepApplication;

  @Input() set sepApplication(value: SepApplication) {
    if (value) {
      this._app = value;
      this.form.patchValue(this._app);
      this.totalServings = this._app.totalServings;
    }
  }

  get sepApplication() {
    return this._app;
  }
  @Input() hideGuestsAndHours = false;
  @Input()
  config: Array<DrinkConfig> = configuration;

  // component state
  busy: Subscription;

  // drink planner form
  form = this.fb.group({
    hours: HOURS_OF_LIQUOR_SERVICE,
    totalMaximumNumberOfGuests: 400,
    beer: 0,
    wine: 0,
    spirits: 0,
  });

  getTotalServings(): number {
    const { hours, totalMaximumNumberOfGuests } = this.form.value;
    return (hours / HOURS_OF_LIQUOR_SERVICE * totalMaximumNumberOfGuests * SERVINGS_PER_PERSON);
  }

  get totalPercentage(): number {
    const { beer, wine, spirits } = this.form.value as { beer: number; wine: number; spirits: number };
    return beer + wine + spirits;
  }

  constructor(private fb: FormBuilder) {
    super();
  }

  ngOnInit() {
    const values = {};
    for (const item of this.config) {
      values[item.group] = item.defaultPercentage;
    }
    this.form.patchValue(values);

    // setup the form's percentage fields so they always add-up to 100%
    this.initForm();
  }

  private initForm(): void {

    this.form.get('hours').valueChanges
      .subscribe(_ => {
        if (!this.hideGuestsAndHours) {
          this.totalServings = this.getTotalServings();
        }
      });

    this.form.get('totalMaximumNumberOfGuests').valueChanges
      .subscribe(_ => {
        if (!this.hideGuestsAndHours) {
          this.totalServings = this.getTotalServings();
        }
      });
  }

  servings(config: DrinkConfig): number {
    const percentage: number = this.form.get(config.group).value;
    return this.totalServings * percentage / 100;
  }

  storageUnits(config: DrinkConfig): number {
    const servings = this.servings(config);
    const storageUnits = servings * config.servingSizeMl / config.storageSizeMl;
    return storageUnits > 0 && storageUnits < 1 ? 1 : storageUnits;
  }

  storageMethodDescription(config: DrinkConfig): string {
    if (config.storageMethod === 'kegs') {
      return `${config.storageMethod} of ${config.group}`;
    } else {
      return `${config.storageSizeMl} ml ${config.storageMethod} of ${config.group}`;
    }
  }
}
