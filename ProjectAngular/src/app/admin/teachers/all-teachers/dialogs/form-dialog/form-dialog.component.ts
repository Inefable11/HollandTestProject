import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Component, Inject, OnInit } from '@angular/core';
import { TeachersService } from '../../teachers.service';
import {
  FormControl,
  Validators,
  FormGroup,
  FormBuilder,
} from '@angular/forms';
import { parameterDetails, Teachers } from '../../teachers.model';
import { formatDate } from '@angular/common';
import { environment } from 'src/environments/environment';
@Component({
  selector: 'app-form-dialog',
  templateUrl: './form-dialog.component.html',
  styleUrls: ['./form-dialog.component.sass'],
})
export class FormDialogComponent implements OnInit{
  action: string;
  dialogTitle: string;
  proForm: FormGroup;
  teachers: Teachers;
  generos: parameterDetails[];
  departamentos: parameterDetails[];
  urlFoto= environment.urlFoto;
  constructor(
    public dialogRef: MatDialogRef<FormDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public teachersService: TeachersService,
    private fb: FormBuilder,
  ) {
    
    // Set the defaults
    this.action = data.action;
    if (this.action === 'edit') {
      this.dialogTitle = data.teachers.name;
      this.teachers = data.teachers;
    } else {
      this.dialogTitle = 'Nuevo Tutor';
      this.teachers = new Teachers({});
    }
    this.proForm = this.createContactForm();
    this.loadData();
  }
  ngOnInit(): void {
   
    
  }
  loadData() {
    this.teachersService.GetParameter(1).subscribe(res =>{
      this.generos = res;
      //console.log("genero: ",this.generos)
    });
    this.teachersService.GetParameter(2).subscribe(res =>{
      this.departamentos = res;
      //console.log("departamentos: ",this.departamentos)
    }); 
    
  }
  formControl = new FormControl('', [
    Validators.required,
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
      id: [this.teachers.id],
      img: [this.teachers.img],
      name: [this.teachers.name],
      email: [
        this.teachers.email,
        [Validators.required, Validators.email, Validators.minLength(5)],
      ],
      date: [
        formatDate(this.teachers.date, 'yyyy-MM-dd', 'en'),
        [Validators.required],
      ],
      gender: [this.teachers.gender],
      mobile: [this.teachers.mobile],
      department: [this.teachers.department],
      degree: [this.teachers.degree],
    });
  }
  submit() {
    //console.log("submit")
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  public confirmAdd(): void {
    //console.log("confirmAdd")
    //console.log('Form Value', this.proForm.value);
    let teacher : Teachers = {
      id: this.teachers.id,
      img: this.teachers.img,
      name: this.proForm.value.name,
      email: this.proForm.value.email,
      date: this.proForm.value.date,
      gender: this.proForm.value.gender,
      mobile: this.proForm.value.mobile,
      department: this.proForm.value.department,
      degree: this.proForm.value.degree,
      /*getRandomID: function (): string {
        throw new Error('Function not implemented.');
      }*/
    }
    ;    
   this.teachersService.updateTeachers(teacher).subscribe(res=>{
    //console.log("res", res)
   })
    this.teachersService.addTeachers(this.proForm.getRawValue());
  }
}
