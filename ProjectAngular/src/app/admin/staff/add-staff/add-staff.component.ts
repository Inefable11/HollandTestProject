import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { parameterDetails } from '../../teachers/all-teachers/teachers.model';
import { accessSystem, Staff } from '../all-staff/staff.model';
import { StaffService } from '../all-staff/staff.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import Swal from 'sweetalert2';
import { Router } from '@angular/router';
@Component({
  selector: 'app-add-staff',
  templateUrl: './add-staff.component.html',
  styleUrls: ['./add-staff.component.sass']
})
export class AddStaffComponent implements OnInit{
  staffForm: FormGroup;
  file: File;
  _typePass:any;
  _typePassConfirm:any;
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
  constructor(private fb: FormBuilder,
    private staffService : StaffService,
    private snackBar: MatSnackBar,
    private router: Router,) {
      this._typePass ='password'
      this._typePassConfirm ='password'
    this.staffForm = this.fb.group({
      first: ['', [Validators.required]],
      last: [''],
      gender: ['', [Validators.required]],
      mobile: ['', [Validators.required]],
      password: ['', [Validators.required]],
      conformPassword: ['', [Validators.required]],
      designation: [''],
      /*department: [''],
      address: [''],*/
      email: [
        '',
        [Validators.required, Validators.email, Validators.minLength(5)]
      ],
      dob: ['', [Validators.required]],
      //education: [''],
      uploadImg: ['']
    });
  }
  ngOnInit(): void {
    let editUser : any =JSON.parse(localStorage.getItem('editUser'))
    if(editUser){
      //console.log('editUser',editUser)

    }
  }
  onSubmit() {
    localStorage.removeItem('editUser');
    //console.log('Form Value', this.staffForm.value);
    let staff : Staff = {
      id: 0,
      img: '',
      name:  this.staffForm.value.first + ' ' + this.staffForm.value.last,
      email:  this.staffForm.value.email,
      date: this.staffForm.value.dob,      
      mobile: this.staffForm.value.mobile,
      designation: this.staffForm.value.designation,   
    }
    let accessSystem : accessSystem ={
      id: 0,
      idUser: 0,
      userType: 1,
      userName: this.staffForm.value.email,
      password: this.staffForm.value.password
    }
    this.staffService.insertStaff(staff,accessSystem,this.file).subscribe(res=>{
      if(res >0){
        Swal.fire({
          position: 'center',
          icon: 'success',
          title: 'Éxito',
          text:'Se ha creado el usuario admin: ' + this.staffForm.value.email,// +' contraseña: '+this.staffForm.value.password,
          showConfirmButton: true,          
        });
        //this.staffForm.reset();
        this.router.navigate(['/admin/staff/all-staff']);
      }

    })
  }
  readUrl(event:any) {    
    this.file = event.target.files[0];  
    //console.log('file', this.file); 
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
    this.staffService.validaEmail(value).subscribe(res=>{
      if(res){
        //this.boolEmail = true;
        Swal.fire({
          position: 'center',
          icon: 'error',
          title: 'Error',
          text:'Este email ya existe elija otro',
          showConfirmButton: true,          
        });
        this.staffForm.get('email').setValue('');
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
    let pass = this.staffForm.get('password').value;
    let passConfirm = this.staffForm.get('conformPassword').value;   
    if(passConfirm == '' || pass == ''){
      return;
    }else{     
      if(pass != passConfirm){
        console.log("pass", pass)
        console.log("passConfirm", passConfirm)
        this.staffForm.get('conformPassword').setErrors(Validators.required);
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
