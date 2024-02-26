import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { accessSystem, parameterDetails, Teachers } from './teachers.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { UnsubscribeOnDestroyAdapter } from 'src/app/shared/UnsubscribeOnDestroyAdapter';
import { environment } from 'src/environments/environment';

@Injectable()
export class TeachersService extends UnsubscribeOnDestroyAdapter {
  
  
    
  private readonly API_URL = 'assets/data/teachers.json';
  isTblLoading = true;
  dataChange: BehaviorSubject<Teachers[]> = new BehaviorSubject<Teachers[]>([]);
  dataParameter: BehaviorSubject<parameterDetails[]> = new BehaviorSubject<parameterDetails[]>([]);  
  AllTeachers : Teachers[] = [];
  // Temporarily stores data from dialogs
  dialogData: any;
  constructor(private httpClient: HttpClient) {
    super();
  }
  get data(): Teachers[] {
    return this.dataChange.value;
  }
  getDialogData() {
    return this.dialogData;
  }
  /** CRUD METHODS */
  getAllTeacherss(): void {
    this.subs.sink = this.httpClient
    .get<any>(`${environment.api}/teachers`).subscribe(
      (data) => {
        this.isTblLoading = false;
        this.dataChange.next(data.objModel);   
        this.AllTeachers = data.objModel;
        //console.log("AllTeachers", this.AllTeachers)
      },
      (error: HttpErrorResponse) => {
        this.isTblLoading = false;
        //console.log(error.name + ' ' + error.message);
      }
      
    );
  }
  GetParameter(id: number) :Observable <any> {
    return  this.httpClient
    .get<any>(`${environment.api}/parameterdetails/GetParameter/` + id)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );    
  }

  addTeachers(teachers: Teachers): void {
    this.dialogData = teachers;

    /*  this.httpClient.post(this.API_URL, teachers).subscribe(data => {
      this.dialogData = teachers;
      },
      (err: HttpErrorResponse) => {
     // error code here
    });*/
  }
  insertTeacher(teacher: Teachers, accessSystem: accessSystem, file: File): Observable<any> {
    const formData = new FormData(); 
    formData.append('file' , file);
    formData.append('teacher', JSON.stringify(teacher));
    formData.append('accessSystem', JSON.stringify(accessSystem));
    //console.log("file", file)
    return this.httpClient
    .post(`${environment.api}/teachers/insertTeacher`, formData)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
  }
  updateTeachers(teachers: Teachers): Observable<any> {
    this.dialogData = teachers;
    ////console.log(teachers);
    return this.httpClient
    .put(`${environment.api}/teachers`, teachers)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
    /* this.httpClient.put(this.API_URL + teachers.id, teachers).subscribe(data => {
      this.dialogData = teachers;
    },
    (err: HttpErrorResponse) => {
      // error code here
    }
  );*/
  }
  deleteTeachers(teachers: Teachers): Observable<any> {
    //console.log(Teachers);
    return this.httpClient
    .post(`${environment.api}/teachers/delete`, teachers)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
    /*  this.httpClient.delete(this.API_URL + id).subscribe(data => {
      //console.log(id);
      },
      (err: HttpErrorResponse) => {
         // error code here
      }
    );*/
  }
  validaEmail(value: string): Observable<any> {
    return this.httpClient
    .get(`${environment.api}/teachers/validaEmail/`+ value)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
  }
}
