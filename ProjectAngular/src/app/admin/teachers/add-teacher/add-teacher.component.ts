import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { accessSystem, parameterDetails, Teachers } from '../all-teachers/teachers.model';
import { TeachersService } from '../all-teachers/teachers.service';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-add-teacher',
  templateUrl: './add-teacher.component.html',
  styleUrls: ['./add-teacher.component.sass'],
})
export class AddTeacherComponent {
  proForm: FormGroup;
  _typePass:any;
  _typePassConfirm:any;
  //iconPass:any;
  boolEmail:boolean=false;
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
  boolValidPass : boolean = false;
departamentos: parameterDetails[];
  file: File;
  boolePass: boolean = false;
  constructor(private fb: FormBuilder,
    private teachersService: TeachersService,
    private snackBar: MatSnackBar,
    private router: Router,) {
      this._typePass ='password'
      this._typePassConfirm ='password'
      //this.iconPass='remove_red_eye'
      this.Builder();
   //console.log("file:",this.file)
    this.loadData();
  }
  Builder() {
    this.proForm = this.fb.group({
      first: ['', [Validators.required]],
      last: [''],
      gender: ['', [Validators.required]],
      mobile: ['', [Validators.required]],
      password: ['', [Validators.required]],
      conformPassword: [''],
      degree: [''],
      department: [''],
      //address: [''],
      email: [
        '',
        [Validators.required, Validators.email, Validators.minLength(5)],
      ],
      dob: ['', [Validators.required]],
      //education: [''],
      uploadImg: [''],
    });
  }
  loadData() {
    this.teachersService.GetParameter(2).subscribe(res =>{
      this.departamentos = res;   
      //console.log('departamentos', this.departamentos);   
    }); 
  }
  onSubmit() {
    //console.log('Form Value', this.proForm.value);
     let teacher : Teachers = {
       id: 0,
       img: '',
       name: this.proForm.value.first + ' ' + this.proForm.value.last,
       email: this.proForm.value.email,
       date: this.proForm.value.dob,
       gender: this.proForm.value.gender,
       mobile: this.proForm.value.mobile,
       department: this.proForm.value.department,
       degree: this.proForm.value.degree,
       /*getRandomID: function (): string {
         throw new Error('Function not implemented.');
       }*/
     }
     let accessSystem : accessSystem ={
       id: 0,
       idUser: 0,
       userType: 2,
       userName: this.proForm.value.email,
       password: this.proForm.value.password
     }
    //this.file = this.proForm.value.uploadImg;    
    this.teachersService.insertTeacher(teacher,accessSystem,this.file).subscribe(res=>{
      if(res >0){
        Swal.fire({
          position: 'center',
          icon: 'success',
          title: 'Éxito',
          text:'Se ha creado el usuario tutor: ' + this.proForm.value.email,// +' contraseña: '+this.proForm.value.password,
          showConfirmButton: true,          
        });
        //this.proForm.reset();
        this.router.navigate(['/admin/teachers/all-teachers']);
      }

    })

  }
  readUrl(event:any) {    
    this.file = event.target.files[0];   
  }
  showNotification(colorName, text, placementFrom, placementAlign) {
    this.snackBar.open(text, '', {
      duration: 2000,
      verticalPosition: placementFrom,
      horizontalPosition: placementAlign,
      panelClass: colorName,
    });
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
 validaPass(value) {
    //console.log("boolePass", this.boolePass);
    if(value.conformPassword == value.password){
      this.boolePass = false;
    }else{
      this.boolePass =  true;
    }

  }
  validaEmail(value){
    //console.log("value", value)
    this.teachersService.validaEmail(value).subscribe(res=>{
      if(res){
        this.boolEmail = true;
        Swal.fire({
          position: 'center',
          icon: 'error',
          title: 'Error',
          text:'Este email ya existe elija otro',
          showConfirmButton: true,          
        });
        this.proForm.get('email').setValue('');
      }else{
        this.boolEmail = false;
      }
      ////console.log("resValida;", res)
    })
  }
  verifyPassword(){
    let pass = this.proForm.get('password').value;
    let passConfirm = this.proForm.get('conformPassword').value;   
    if(passConfirm == '' || pass == ''){
      return;
    }else{     
      if(pass != passConfirm){
        console.log("pass", pass)
        console.log("passConfirm", passConfirm)
        this.proForm.get('conformPassword').setErrors(Validators.required);
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

