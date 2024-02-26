import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Component, Inject, OnInit } from '@angular/core';
import { DepartmentService } from '../../department.service';
import {
  FormControl,
  Validators,
  FormGroup,
  FormBuilder
} from '@angular/forms';
import { Department } from '../../department.model';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { parameterDetails } from 'src/app/admin/teachers/all-teachers/teachers.model';
@Component({
  selector: 'app-form-dialog',
  templateUrl: './form-dialog.component.html',
  styleUrls: ['./form-dialog.component.sass'],
  providers: [{ provide: MAT_DATE_LOCALE, useValue: 'en-GB' }]
})
export class FormDialogComponent implements OnInit{
  action: string;
  dialogTitle: string;
  departmentForm: FormGroup;
  department: Department;
  AllTeachers: any = [];
  constructor(
    public dialogRef: MatDialogRef<FormDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public departmentService: DepartmentService,
    private fb: FormBuilder
  ) {
    // Set the defaults
    this.action = data.action;
    if (this.action === 'edit') {
      this.dialogTitle = data.department.dName;
      this.department = data.department;
    } else {
      this.dialogTitle = 'Nueva Aula';
      this.department = new Department({});
    }
    this.departmentForm = this.createContactForm();
  }
  ngOnInit(): void {
    /*this.departmentService.GetParameter(2).subscribe(res =>{
      this.depart = res;
      //console.log("depart: ",this.depart)
    });*/
    //console.log("data", this.data.action)
    this.departmentService.getAllTeachers().subscribe(res =>{
      this.AllTeachers = res;      
    })

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
      id: [this.department.id],
      dName: [this.department.dName, [Validators.required]],
      hod: [this.department.hod, [Validators.required]],
      phone: [this.department.phone, [Validators.required]],
      email: [
        this.department.email,
        [Validators.required, Validators.email, Validators.minLength(5)]
      ],
      sYear: [this.department.sYear, [Validators.required]],
      sCapacity: [this.department.sCapacity, [Validators.required]]
    });
  }
  submit() {
    // emppty stuff
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  public confirmAdd(): void {    
    let depa : Department ={
      id: this.data.action === 'add'? 0 : this.data.department.id,
      dName: this.departmentForm.value.dName,
      hod: this.departmentForm.value.hod,
      phone: this.departmentForm.value.phone,
      email: this.departmentForm.value.email,
      sYear: this.departmentForm.value.sYear,
      sCapacity: this.departmentForm.value.sCapacity
    }
    //console.log("depa", depa)
    if(this.data.action === 'add'){
      this.departmentService.addDepartment(depa).subscribe(res =>{

      })

    }else{
      this.departmentService.updateDepartment(depa).subscribe(res =>{
        
      })

    }
    this.departmentService.addDepartment(this.departmentForm.getRawValue());
  }
}
