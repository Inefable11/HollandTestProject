import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-form-dialog-careers',
  templateUrl: './form-dialog-careers.component.html',
  styleUrls: ['./form-dialog-careers.component.css']
})
export class FormDialogCareersComponent implements OnInit {
  urlFoto= environment.urlFoto;
  constructor(
    public dialogRef: MatDialogRef<FormDialogCareersComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) { 
    //console.log("data", data)
  }

  ngOnInit(): void {
  }

}
