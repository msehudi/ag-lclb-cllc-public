import { ComponentFixture, TestBed, waitForAsync } from "@angular/core/testing";

import { EligibilityFormComponent } from "./eligibility-form.component";
import { NO_ERRORS_SCHEMA } from "@angular/core";
import { ReactiveFormsModule, FormBuilder } from "@angular/forms";
import { MatCheckboxModule } from "@angular/material/checkbox";
import { MatDialogRef } from "@angular/material/dialog";
import { MatRadioModule } from "@angular/material/radio";
import { EligibilityFormDataService } from "@services/eligibility-data.service";

describe("EligibilityFormComponent",
  () => {
    let component: EligibilityFormComponent;
    let fixture: ComponentFixture<EligibilityFormComponent>;

    beforeEach(waitForAsync(() => {
      TestBed.configureTestingModule({
          declarations: [EligibilityFormComponent],
          imports: [ReactiveFormsModule, MatRadioModule, MatCheckboxModule],
          schemas: [NO_ERRORS_SCHEMA],
          providers: [
            FormBuilder,
            { provide: MatDialogRef, useValue: {} },
            { provide: EligibilityFormDataService, useValue: {} }
          ]
        })
        .compileComponents();
    }));

    beforeEach(() => {
      fixture = TestBed.createComponent(EligibilityFormComponent);
      component = fixture.componentInstance;
      fixture.detectChanges();
    });

    it("should create",
      () => {
        expect(component).toBeTruthy();
      });
  });
