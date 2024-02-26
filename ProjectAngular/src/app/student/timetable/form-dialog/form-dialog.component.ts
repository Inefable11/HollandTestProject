import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-form-dialog',
  templateUrl: './form-dialog.component.html',
  styleUrls: ['./form-dialog.component.css']
})
export class FormDialogComponent implements OnInit {

  constructor( public dialogRef: MatDialogRef<FormDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,) { 
      ////console.log("data:", data)
    }

  ngOnInit(): void {
    setTimeout(() => {
      this.closed()
     }, 18000);
  }
  closed() {
    this.dialogRef.close();
  }

}
