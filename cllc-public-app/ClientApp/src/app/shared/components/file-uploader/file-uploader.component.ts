import { Component, OnInit, Input, Output, EventEmitter, OnDestroy } from "@angular/core";
import { NgxFileDropEntry, FileSystemFileEntry, FileSystemDirectoryEntry } from "ngx-file-drop";
import { FileSystemItem } from "@models/file-system-item.model";
import { Subscription } from "rxjs";
import { ApplicationDataService } from "@services/application-data.service";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { MatSnackBar } from "@angular/material/snack-bar";

export interface DropdownOption {
  id: string;
  name: string;
}

@Component({
  selector: "app-file-uploader",
  templateUrl: "./file-uploader.component.html",
  styleUrls: ["./file-uploader.component.scss"]
})
export class FileUploaderComponent implements OnInit, OnDestroy {
  @Input()
  uploadUrl: string;
  @Input()
  fileTypes = "";
  @Input()
  documentType: string;
  @Input()
  entityName: string;
  @Input()
  entityId: string;
  @Input()
  disableUploads = false; // force uploads to be disabled
  @Input()
  multipleFiles = true;
  @Input()
  extensions: string[] = ["pdf"];
  @Input()
  uploadHeader = "TO UPLOAD DOCUMENTS, DRAG FILES HERE OR";
  @Input()
  enableFileDeletion = true;
  @Input()
  maxNumberOfFiles = 10;
  @Input()
  useDocumentTypeForName = false;
  @Input()
  publicAccess = false;
  @Output()
  numberOfUploadedFiles = new EventEmitter<number>();
  busy: Subscription;
  attachmentURL: string;
  actionPrefix: string;
  Math = Math;
  files: FileSystemItem[] = [];
  dataLoaded: boolean;
  fileReqOngoing: boolean;
  subscriptionList: Subscription[] = [];

  // TODO: move http call to a service
  constructor(
    private http: HttpClient,
    private snackBar: MatSnackBar,
    private adoxioApplicationDataService: ApplicationDataService) {
  }

  ngOnInit(): void {
    if (this.publicAccess) {
      this.actionPrefix = "public-";
    } else {
      this.actionPrefix = "";
    }
    this.attachmentURL = `api/file/${this.entityId}/${this.actionPrefix}attachments/${this.entityName}`;
    this.getUploadedFileData();
  }

  dropped(event: NgxFileDropEntry[]) {
    const files = event;
    let newFileCount = 0;
    for (const droppedFile of files) {
      newFileCount += 1;
    }
    let count = this.getCurrentLastFileCounter() + 1;
    if (files.length > 1 && !this.multipleFiles) {
      this.snackBar.open("Only one file can be uploaded here",
        "Fail",
        { duration: 3500, panelClass: ["red-snackbar"] });
      return;
    }
    if (this.maxNumberOfFiles < (this.files.length + newFileCount)) {
      alert(`Only ${this.maxNumberOfFiles} files can be uploaded here`);
      return;
    }
    for (const droppedFile of files) {
      if (droppedFile.fileEntry.isFile) {
        const fileEntry = droppedFile.fileEntry as FileSystemFileEntry;
        fileEntry.file((file: File) => {
          this.uploadFile(file, count);
          count += 1;
        });
      } else {
        // It was a directory (empty directories are added, otherwise only files)
        const fileEntry = droppedFile.fileEntry as FileSystemDirectoryEntry;
        // console.log(droppedFile.relativePath, fileEntry);
      }
    }
  }

  getCurrentLastFileCounter(): number {
    let lastCount = 0;
    if (this.files.length) {
      const counts = this.files.map(file => {
          const match = file.name.match(/_(\d+)\.([^\.]+)$/);
          if (match) {
            return parseInt(match[1], 10);
          } else {
            return 0;
          }

        }).sort()
        .reverse();
      lastCount = counts[0];
    }
    return lastCount;
  }

  onBrowserFileSelect(event: any, input: any) {
    const uploadedFiles = event.target.files;
    let newFileCount = 0;
    for (const droppedFile of uploadedFiles) {
      newFileCount += 1;
    }
    let count = this.getCurrentLastFileCounter() + 1;
    if (uploadedFiles.length > 1 && !this.multipleFiles) {
      this.snackBar.open("Only one file can be uploaded here",
        "Fail",
        { duration: 3500, panelClass: ["red-snackbar"] });
      return;
    }
    if (this.maxNumberOfFiles < (this.files.length + newFileCount)) {
      alert(`Only ${this.maxNumberOfFiles} files can be uploaded here`);
      return;
    }
    for (const file of uploadedFiles) {
      this.uploadFile(file, count);
      count += 1;
    }

    input.value = "";
  }

  uploadFile(file, count) {
    const validExt = this.extensions.filter(ex => file.name.toLowerCase().endsWith(ex)).length > 0;
    if (!validExt) {
      this.snackBar.open("File type not supported.", "Fail", { duration: 3500, panelClass: ["red-snackbar"] });
      return;
    }

    if (file && file.name && file.name.length > 128) {
      this.snackBar.open("File name must be 128 characters or less.",
        "Fail",
        { duration: 3500, panelClass: ["red-snackbar"] });
      return;
    }

    const formData = new FormData();
    let fileName = file.name;
    const extension = file.name.match(/\.([^\.])+$/)[0];
    if (this.useDocumentTypeForName) {
      fileName = (count) + extension;
    }
    formData.append("file", file, fileName);
    formData.append("documentType", this.documentType);
    const headers = new HttpHeaders();
    this.fileReqOngoing = true;
    const sub = this.http.post(this.attachmentURL, formData, { headers: headers }).subscribe(result => {
        this.getUploadedFileData();
      },
      err => {
        this.snackBar.open("Failed to upload file", "Fail", { duration: 3500, panelClass: ["red-snackbar"] });
        this.fileReqOngoing = false;
      });
    // this.busy = sub;
  }

  getUploadedFileData() {
    this.fileReqOngoing = true;
    const headers = new HttpHeaders({
      // 'Content-Type': 'application/json'
    
    });
    const getFileURL = this.attachmentURL + "/" + this.documentType;
    const sub = this.http.get<FileSystemItem[]>(getFileURL, { headers: headers })
      .subscribe((data) => {
          data.forEach(file => {
            if (this.useDocumentTypeForName) {
              file.name = this.documentType + "_" + file.name;
            }
          });
          // sort by filename
          data = data.sort((fileA, fileB) => {
            if (fileA.name > fileB.name) {
              return 1;
            } else {
              return -1;
            }
          });
          this.subscriptionList.push(sub);
          // this.busy = sub;

          // convert bytes to KB
          data.forEach((entry) => {
            entry.size = Math.ceil(entry.size / 1024);
            entry.downloadUrl =
              `api/file/${this.entityId}/${this.actionPrefix}download-file/${this.entityName}/${entry.name}`;
            entry.downloadUrl += `?serverRelativeUrl=${encodeURIComponent(entry.serverrelativeurl)}&documentType=${this
              .documentType}`;
          });
          this.files = data;
          this.numberOfUploadedFiles.emit(this.files.length);
          this.dataLoaded = true;
          this.fileReqOngoing = false;
        },
        err => {
          this.snackBar.open("Failed to get files", "Fail", { duration: 3500, panelClass: ["red-snackbar"] });
          this.fileReqOngoing = false;
        });
    this.subscriptionList.push(sub);
  }

  deleteFile(relativeUrl: string) {
    this.fileReqOngoing = true;
    const headers = new HttpHeaders({
      'Content-Type': "application/json"
    });
    const queryParams = `?serverRelativeUrl=${encodeURIComponent(relativeUrl)}&documentType=${this.documentType}`;
    const sub = this.http.delete(this.attachmentURL + queryParams, { headers: headers }).subscribe(result => {
        this.getUploadedFileData();
      },
      err => {
        this.snackBar.open("Failed to delete file", "Fail", { duration: 3500, panelClass: ["red-snackbar"] });
        this.fileReqOngoing = false;
      });

    this.subscriptionList.push(sub);
    // this.busy = sub;
  }

  disableFileUpload(): boolean {
    return (!this.multipleFiles && (this.files && this.files.length > 0)) ||
      (this.multipleFiles && this.maxNumberOfFiles <= (this.files.length)) ||
      this.disableUploads;
  }

  fileOver(event) {
    // console.log(event);
  }

  fileLeave(event) {
    // console.log(event);
  }

  browseFiles(browserMultiple, browserSingle) {
    if (!this.disableFileUpload()) {
      if (this.multipleFiles) {
        browserMultiple.click();
      } else {
        browserSingle.click();
      }
    }
  }

  ngOnDestroy() {
    this.subscriptionList.forEach(sub => sub.unsubscribe());
  }
}
