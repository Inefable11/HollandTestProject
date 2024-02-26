import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-form-dialog-institutions',
  templateUrl: './form-dialog-institutions.component.html',
  styleUrls: ['./form-dialog-institutions.component.css']
})
export class FormDialogInstitutionsComponent implements OnInit {
  urlFoto= environment.urlFoto;
  constructor(
    public dialogRef: MatDialogRef<FormDialogInstitutionsComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) {
    //console.log("data", data)
   }

  ngOnInit(): void {
  }

}
