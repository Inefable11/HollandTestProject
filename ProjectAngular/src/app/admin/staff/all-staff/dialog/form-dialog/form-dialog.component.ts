import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Component, Inject } from '@angular/core';
import { StaffService } from '../../staff.service';
import {
  FormControl,
  Validators,
  FormGroup,
  FormBuilder
} from '@angular/forms';
import { Staff } from '../../staff.model';
import { formatDate } from '@angular/common';
import { environment } from 'src/environments/environment';
@Component({
  selector: 'app-form-dialog',
  templateUrl: './form-dialog.component.html',
  styleUrls: ['./form-dialog.component.sass']
})
export class FormDialogComponent {
  action: string;
  dialogTitle: string;
  staffForm: FormGroup;
  staff: Staff;
  urlFoto= environment.urlFoto;
  constructor(
    public dialogRef: MatDialogRef<FormDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public staffService: StaffService,
    private fb: FormBuilder
  ) {
    // Set the defaults
    this.action = data.action;
    if (this.action === 'edit') {
      this.dialogTitle = data.staff.name;
      this.staff = data.staff;
    } else {
      this.dialogTitle = 'New Staff';
      this.staff = new Staff({});
    }
    this.staffForm = this.createContactForm();
  }
  formControl = new FormControl('', [
    Validators.required
    // Validators.email,
  ]);
  getErrorMessage() {
    return this.formControl.hasError('required')
      ? 'Required field'
      : this.formControl.hasError('email')
      ? 'Not a valid email'
      : '';
  }
  createContactForm(): FormGroup {
    return this.fb.group({
      id: [this.staff.id],
      img: [this.staff.img],
      name: [this.staff.name],
      email: [
        this.staff.email,
        [Validators.required, Validators.email, Validators.minLength(5)]
      ],
      date: [
        formatDate(this.staff.date, 'yyyy-MM-dd', 'en'),
        [Validators.required]
      ],
      designation: [this.staff.designation],
      mobile: [this.staff.mobile]
    });
  }
  submit() {
    ////console.log("submit");
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  public confirmAdd(): void {
    ////console.log("confirmAdd",this.staffForm.value);
    let staff : Staff= {
      id: this.data.staff.id,
      img: this.data.staff.img,
      name: this.staffForm.value.name,
      email: this.staffForm.value.email,
      date: this.staffForm.value.date,
      mobile: this.staffForm.value.mobile,
      designation: this.staffForm.value.designation
    }
    ////console.log("staff:", staff);
    this.staffService.updateStaff(staff).subscribe(res =>{
      //console.log("res", res)
    })
    this.staffService.addStaff(this.staffForm.getRawValue());
  }
}
