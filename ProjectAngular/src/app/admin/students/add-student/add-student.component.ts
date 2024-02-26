import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { parameterDetails } from '../../teachers/all-teachers/teachers.model';
import { accessSystem, Students } from '../all-students/students.model';
import { StudentsService } from '../all-students/students.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import Swal from 'sweetalert2';
import { TeachersService } from '../../teachers/all-teachers/teachers.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.sass']
})
export class AddStudentComponent implements OnInit{
  stdForm: FormGroup;
  aulas :any[]=[];
  generos : parameterDetails[]=[
    {
        "id": 1,
        "idParameter": 1,
        "code": "MASC",
        "value_1": "MASCULINO",
        "value_2": null,
        "value_3": null,
        "sort": null,
        "isActive": true
    },
    {
        "id": 2,
        "idParameter": 1,
        "code": "FEM",
        "value_1": "FEMENINO",
        "value_2": null,
        "value_3": null,
        "sort": null,
        "isActive": true
    },
    {
        "id": 3,
        "idParameter": 1,
        "code": "OTR",
        "value_1": "OTRO",
        "value_2": null,
        "value_3": null,
        "sort": null,
        "isActive": true
    }
]
_typePass:any;
  _typePassConfirm:any;
file: File;
  constructor(private fb: FormBuilder,
              private studentService:StudentsService,
              private snackBar: MatSnackBar,
              private router: Router,) {
                this._typePass ='password'
      this._typePassConfirm ='password'
    this.stdForm = this.fb.group({
      first: ['', [Validators.required]],
      last: [''],
      rollNo: ['', [Validators.required]],
      gender: ['', [Validators.required]],
      email: [
        '',
        [Validators.required, Validators.email, Validators.minLength(5)]
      ],
      mobile: ['', [Validators.required]],
      rDate: ['', [Validators.required]],
      department: [''],
      parentName: ['', [Validators.required]],
      password: ['', [Validators.required]],
      conformPassword: ['', [Validators.required]],
      parentNo: [''],
      dob: ['', [Validators.required]],
      bGroup: [''],
      address: [''],
      uploadImg: ['']
    });
  }
  ngOnInit(): void {
    this.studentService.GetAulas().subscribe( res =>{
      this.aulas = res;
      //console.log("aulas", this.aulas)
    })

    
  }
  onSubmit() {
    //console.log('Form Value', this.stdForm.value);
    let form = this.stdForm.value;
    let student : Students={
      id: 0,
      img: '',
      name: form.first+' '+form.last,//
      email: form.email,//
      dateJoin: form.dob,
      gender: form.gender,
      mobile: form.mobile,
      department: form.department,
      address: form.address,
      rollNo: form.rollNo,//
      bloodGroup: form.bloodGroup,
      dateBirth: form.rDate,
      studentCode: form.rollNo,//
      parentsName: form.parentName,
      parentsPhone: form.parentNo
    }
    let accessSystem : accessSystem ={
      id: 0,
      idUser: 0,
      userType: 3,
      userName: form.email,
      password: form.password//
    }
    this.studentService.insertStudent(student, accessSystem, this.file).subscribe(res=>{
      if(res >0){
        Swal.fire({
          position: 'center',
          icon: 'success',
          title: 'Éxito',
          text:'Se ha creado el usuario estudiante: ' + this.stdForm.value.email,// +' contraseña: '+this.stdForm.value.password,
          showConfirmButton: true,          
        });
        //this.stdForm.reset();
        this.router.navigate(['/admin/students/all-students']);
      }
    })
  }
  readUrl(event:any) {    
    this.file = event.target.files[0];   
    //console.log("file: ", this.file);
  }
  showNotification(colorName, text, placementFrom, placementAlign) {
    this.snackBar.open(text, '', {
      duration: 2000,
      verticalPosition: placementFrom,
      horizontalPosition: placementAlign,
      panelClass: colorName,
    });
  }
  validaEmail(value){
    //console.log("value", value)
    this.studentService.validaEmail(value).subscribe(res=>{
      if(res){
        //this.boolEmail = true;
        Swal.fire({
          position: 'center',
          icon: 'error',
          title: 'Error',
          text:'Este email ya existe elija otro',
          showConfirmButton: true,          
        });
        this.stdForm.get('email').setValue('');
      }else{
        //this.boolEmail = false;
      }
      ////console.log("resValida;", res)
    })
  }
  typePass(){
    if(this._typePass == 'password'){
      this._typePass = 'text';
      //this.iconPass='visibility_off'
    }else{
      this._typePass = 'password';
      //this.iconPass='remove_red_eye'
    }

  }
  typePassConfirm(){
    if(this._typePassConfirm == 'password'){
      this._typePassConfirm = 'text';
      //this.iconPass='visibility_off'
    }else{
      this._typePassConfirm = 'password';
      //this.iconPass='remove_red_eye'
    }

  }
  verifyPassword(){
    let pass = this.stdForm.get('password').value;
    let passConfirm = this.stdForm.get('conformPassword').value;   
    if(passConfirm == '' || pass == ''){
      return;
    }else{     
      if(pass != passConfirm){
        console.log("pass", pass)
        console.log("passConfirm", passConfirm)
        this.stdForm.get('conformPassword').setErrors(Validators.required);
        Swal.fire({
          position: 'center',
          icon: 'error',
          title: 'Error',
          text:'Las contraseñas no coinciden',
          showConfirmButton: true,          
        });
      }
    }
  }
}
