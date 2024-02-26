import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Component, Inject, OnInit } from '@angular/core';
import { StudentsService } from '../../students.service';
import {
  FormControl,
  Validators,
  FormGroup,
  FormBuilder
} from '@angular/forms';
import { Students } from '../../students.model';
import { formatDate } from '@angular/common';
import { environment } from 'src/environments/environment';
import { parameterDetails } from 'src/app/admin/teachers/all-teachers/teachers.model';

@Component({
  selector: 'app-form-dialog',
  templateUrl: './form-dialog.component.html',
  styleUrls: ['./form-dialog.component.sass']
})
export class FormDialogComponent implements OnInit{
  action: string;
  dialogTitle: string;
  stdForm: FormGroup;
  students: Students;
  urlFoto= environment.urlFoto;
  generos: parameterDetails[];
  aulas :any[]=[];
  constructor(
    public dialogRef: MatDialogRef<FormDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public studentsService: StudentsService,
    private fb: FormBuilder,
  ) {
    // Set the defaults
    this.action = data.action;
    if (this.action === 'edit') {
      this.dialogTitle = data.students.name;
      this.students = data.students;
    } else {
      this.dialogTitle = 'New Students';
      this.students = new Students({});
    }
    this.stdForm = this.createContactForm();
  }
  ngOnInit(): void {
    this.studentsService.GetParameter(1).subscribe(res =>{
      this.generos = res;
      ////console.log("genero: ",this.generos)
    });
    this.studentsService.GetAulas().subscribe( res =>{
      this.aulas = res;
      ////console.log("aulas", this.aulas)
    })
    //console.log("fecha", this.students.dateJoin)
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
      id: [this.students.id],
      img: [this.students.img],
      name: [this.students.name],
      email: [
        this.students.email,
        [Validators.required, Validators.email, Validators.minLength(5)]
      ],
      date: [
        formatDate(this.students.dateJoin, 'yyyy-MM-dd', 'en'),
        [Validators.required]
      ],
      gender: [this.students.gender],
      mobile: [this.students.mobile],
      department: [this.students.department],
      rollNo: [this.students.studentCode]
    });
  }
  submit() {
    
    let student : Students = {
      id: this.students.id === undefined? 0 :this.students.id,
      img: this.stdForm.value.img,
      name: this.stdForm.value.name,
      email: this.stdForm.value.email,
      dateJoin: this.stdForm.value.date,
      gender: this.stdForm.value.gender,
      mobile: this.stdForm.value.mobile.toString(),
      department: this.stdForm.value.department,
      address: this.data.students.address,
      rollNo: this.stdForm.value.rollNo,
      bloodGroup: this.data.students.bloodGroup,
      dateBirth: this.data.students.dateBirth,
      studentCode: this.stdForm.value.rollNo.trim(),
      parentsName: this.data.students.parentsName,
      parentsPhone: this.data.students.parentsPhone,
      /*getRandomID: function (): string {
        throw new Error('Function not implemented.');
      }*/
    }
    //console.log("student: ", student)
    this.studentsService.updateStudents(student).subscribe(res=>{
      //console.log("res", res)
     })
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  public confirmAdd(): void {
    this.studentsService.addStudents(this.stdForm.getRawValue());
  }
}
