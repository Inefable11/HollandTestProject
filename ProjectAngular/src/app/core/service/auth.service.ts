import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from '../models/user';
import { environment } from 'src/environments/environment';
import { Students } from 'src/app/admin/students/all-students/students.model';
import { accessSystem } from 'src/app/admin/teachers/all-teachers/teachers.model';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
 
  private currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;
  
  constructor(private http: HttpClient) {
    this.currentUserSubject = new BehaviorSubject<User>(
      JSON.parse(localStorage.getItem('currentUser'))
    );
    this.currentUser = this.currentUserSubject.asObservable();
  }

  public get currentUserValue(): User {
    return this.currentUserSubject.value;
  }

  login(credenciales: any) {
    const headers = new HttpHeaders()
    .append('Content-Type', 'application/json')
      .append('Access-Control-Allow-Headers', 'Content-Type')
      .append('Access-Control-Allow-Methods', 'POST')
      .append('Access-Control-Allow-Origin', '*');
      //console.log("headers", headers)
    return this.http
      .post<any>(`${environment.api}/accesssystem/login`, credenciales,  {headers})
      .pipe(
        map((user) => {
          // store user details and jwt token in local storage to keep user logged in between page refreshes
          ////console.log("environment: ", environment.apiUrl)
          if(credenciales.typeLogin === 1){
            user.objModel.role ='Admin';
          }
          if(credenciales.typeLogin === 2){
            user.objModel.role ='Tutor';
          }
          if(credenciales.typeLogin === 3){
            user.objModel.role ='Estudiante';
          }
          localStorage.setItem('currentUser', JSON.stringify(user.objModel));
          this.currentUserSubject.next(user.objModel);
          //console.log("user", user)
          return user.objModel;
        })
      );
  }

  logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('currentUser');
    this.currentUserSubject.next(null);
    return of({ success: false });
  }
  insertStudent(student: Students, accessSystem: accessSystem, file: File): Observable<any> {
    const formData = new FormData(); 
    formData.append('file' , file);
    formData.append('student', JSON.stringify(student));
    formData.append('accessSystem', JSON.stringify(accessSystem));
    return this.http
    .post(`${environment.api}/students/insertStudent`, formData)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
  }
  validaEmail(value: string): Observable<any> {
    return this.http
    .get(`${environment.api}/teachers/validaEmail/`+ value)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
  }
}
