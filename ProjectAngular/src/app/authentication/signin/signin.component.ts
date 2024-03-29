import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/core/service/auth.service';
import { Role } from 'src/app/core/models/role';
import { UnsubscribeOnDestroyAdapter } from 'src/app/shared/UnsubscribeOnDestroyAdapter';
@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.scss'],
})

export class SigninComponent
  extends UnsubscribeOnDestroyAdapter
  implements OnInit
{
  authForm: FormGroup;
  submitted = false;
  loading = false;
  error = '';
  hide = true;
  credenciales : CredencialesUsuaroBE ={
    username: '',
    password: '',
    typeLogin: 1
  }
  labelUser='Admin';
  constructor(
    private formBuilder: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private authService: AuthService
  ) {
    super();
  }

  ngOnInit() {

    this.authForm = this.formBuilder.group({
      username: ['', Validators.required],
      password: ['', Validators.required],
    });
  }
  get f() {
    return this.authForm.controls;
  }
  adminSet() {
    this.credenciales.typeLogin =1;
    this.labelUser='Admin';
  }
  teacherSet() {
    this.credenciales.typeLogin =2;
    this.labelUser='Tutor';
  }
  studentSet() {
    this.credenciales.typeLogin =3;
    this.labelUser='Estudiante';
  }
  onSubmit() {
    this.submitted = true;
    this.loading = true;
    this.error = '';
    if (this.authForm.invalid) {
      this.error = 'Username and Password not valid !';
      return;
    } else {
      this.credenciales.username =this.f.username.value;
      this.credenciales.password =this.f.password.value;
      //console.log(this.credenciales)
      this.subs.sink = this.authService
        .login(this.credenciales)
        .subscribe(
          (res) => {
            if (res) {
              setTimeout(() => {
                const role = this.authService.currentUserValue.role;
                if (role === Role.All || role === Role.Admin) {
                  this.router.navigate(['/admin/dashboard/main']);
                } else if (role === Role.Teacher) {
                  this.router.navigate(['/teacher/dashboard']);
                } else if (role === Role.Student) {
                  this.router.navigate(['/student/dashboard']);
                } else {
                  this.router.navigate(['/authentication/signin']);
                }
                this.loading = false;
              }, 1000);
            } else {
              this.error = 'Invalid Login';
            }
          },
          (error) => {
            if(error.toString().includes("setting 'role'")){
              error = 'No se estableció el rol correcto, elija su rol (Admin, tutor, estudiante)'

            }
            this.error = error;
            this.submitted = false;
            this.loading = false;
          }
        );
    }
  }
}
export  class CredencialesUsuaroBE {
  username:  string;
  password:  string;
  typeLogin: number;  
}