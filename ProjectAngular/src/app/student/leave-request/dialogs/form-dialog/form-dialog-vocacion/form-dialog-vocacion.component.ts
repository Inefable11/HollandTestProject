import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-form-dialog-vocacion',
  templateUrl: './form-dialog-vocacion.component.html',
  styleUrls: ['./form-dialog-vocacion.component.css']
})
export class FormDialogVocacionComponent implements OnInit {

  constructor(
    public dialogRef: MatDialogRef<FormDialogVocacionComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) {     
  }

  ngOnInit(): void {
    //console.log("data", this.data) 
  }

}
