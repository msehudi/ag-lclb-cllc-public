
import { ApplicationType } from "./application-type.model";

export class CovidApplication {
  id: string;
  jobNumber: string;
  additionalPropertyInformation: string;
  invoiceId: string;
  applyingPerson: string;
  authorizedToSubmit: boolean;

  createdOn: Date;
  contactPersonEmail: string;
  contactPersonFirstName: string;
  contactPersonLastName: string;
  contactPersonPhone: string;
  contactPersonRole: string;

  establishmentAddress: string;
  establishmentName: string;
  establishmentAddressCity: string;
  establishmentAddressPostalCode: string;
  establishmentAddressStreet: string;
  establishmentParcelId: string;
  establishmentPhone: string;

  addressCity: string;
  addressPostalCode: string;
  addressStreet: string;

  licenceType: string;
  modifiedOn: Date;
  name: string;
  applicationType: ApplicationType;
  description1: string;
  isApplicationComplete: string;
  proposedEstablishmentIsAlr: boolean;
}
