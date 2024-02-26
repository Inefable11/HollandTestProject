import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { accessSystem, parameterDetails } from 'src/app/admin/teachers/all-teachers/teachers.model';
import { Students } from 'src/app/admin/students/all-students/students.model';
import { MatSnackBar } from '@angular/material/snack-bar';
import { AuthService } from 'src/app/core/service/auth.service';
import { formatDate } from '@angular/common';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss'],
})
export class SignupComponent implements OnInit {
  authForm: FormGroup;
  submitted = false;
  returnUrl: string;
  hide = true;
  chide = true;
  file: File;
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
  constructor(
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private authService: AuthService,
    private router: Router,
  ) {
    this.authForm = this.formBuilder.group({
      username: ['', Validators.required],
      rollNo: ['', [Validators.required]],
      email: [
        '',
        [Validators.required, Validators.email, Validators.minLength(5)],
      ],
      password: ['', Validators.required],
      cpassword: ['', Validators.required],
      mobile: ['', [Validators.required]],
      uploadImg: ['']
    });
  }
  ngOnInit() {
   
    // get return url from route parameters or default to '/'
    this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || '/';
  }
  get f() {
    return this.authForm.controls;
  }
  onSubmit() {
    
    let student : Students={
      id: 0,
      img: '',
      name: this.authForm.value.username,
      email: this.authForm.value.email,
      dateJoin: formatDate(new Date(), 'yyyy-MM-dd hh:mm:ssZZZZZ', 'en_US'),
      gender: '',
      mobile: this.authForm.value.mobile,
      department: 1,
      address: '',
      rollNo: this.authForm.value.rollNo,
      bloodGroup: '',
      dateBirth: formatDate(new Date(), 'yyyy-MM-dd hh:mm:ssZZZZZ', 'en_US'),
      studentCode: this.authForm.value.rollNo,
      parentsName: '',
      parentsPhone: ''
    }
    let accessSystem : accessSystem ={
      id: 0,
      idUser: 0,
      userType: 3,
      userName: this.authForm.value.email,
      password: this.authForm.value.password
    }
    //console.log("student", student);
    //console.log("accessSystem", accessSystem);    
    
    this.submitted = true;
    // stop here if form is invalid
    if (this.authForm.invalid) {
      return;
    } else {
      this.authService.insertStudent(student, accessSystem, this.file).subscribe(res=>{
        if(res >0){
          Swal.fire({
            position: 'center',
            icon: 'success',
            title: 'Éxito',
            text:'Se ha creado el usuario usuario: ' + this.authForm.value.email,// +' contraseña: '+this.authForm.value.password,
            showConfirmButton: true,          
          });
          //this.stdForm.reset();
          this.router.navigate(['/authentication/signin']);
        }
      })
      
    }
  }
  readUrl(event:any) {    
    this.file = event.target.files[0];   
    //console.log("file: ", this.file);
  }
  validaEmail(value){
    //console.log("value", value)
    this.authService.validaEmail(value).subscribe(res=>{
      if(res){
        //this.boolEmail = true;
        Swal.fire({
          position: 'center',
          icon: 'error',
          title: 'Error',
          text:'Este email ya existe elija otro',
          showConfirmButton: true,          
        });
        this.authForm.get('email').setValue('');
      }else{
        //this.boolEmail = false;
      }
      ////console.log("resValida;", res)
    })
  }
}
