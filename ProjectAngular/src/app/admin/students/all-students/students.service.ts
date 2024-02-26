import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { accessSystem, Students } from './students.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { UnsubscribeOnDestroyAdapter } from 'src/app/shared/UnsubscribeOnDestroyAdapter';
import { environment } from 'src/environments/environment';
@Injectable()
export class StudentsService extends UnsubscribeOnDestroyAdapter {
  
  
  private readonly API_URL = 'assets/data/students.json';
  isTblLoading = true;
  dataChange: BehaviorSubject<Students[]> = new BehaviorSubject<Students[]>([]);
  // Temporarily stores data from dialogs
  dialogData: any;
  AllStudents: Students[];
  constructor(private httpClient: HttpClient) {
    super();
  }
  get data(): Students[] {
    return this.dataChange.value;
  }
  getDialogData() {
    return this.dialogData;
  }
  /** CRUD METHODS */
  getAllStudentss(): void {
    this.subs.sink = this.httpClient.get<any>(`${environment.api}/students`).subscribe(
      (data) => {
        this.isTblLoading = false;
        this.dataChange.next(data.objModel);
        this.AllStudents = data.objModel;
        //console.log("AllStudents", this.AllStudents)
      },
      (error: HttpErrorResponse) => {
        this.isTblLoading = false;
        //console.log(error.name + ' ' + error.message);
      }
    );
  }
  addStudents(students: Students): void {
    this.dialogData = students;

    /*  this.httpClient.post(this.API_URL, students).subscribe(data => {
      this.dialogData = students;
      },
      (err: HttpErrorResponse) => {
     // error code here
    });*/
  }
  insertStudent(student: Students, accessSystem: accessSystem, file: File): Observable<any> {
    const formData = new FormData(); 
    formData.append('file' , file);
    formData.append('student', JSON.stringify(student));
    formData.append('accessSystem', JSON.stringify(accessSystem));
    return this.httpClient
    .post(`${environment.api}/students/insertStudent`, formData)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
  }
  updateStudents(student: Students): Observable<any>  {
    this.dialogData = student;
    return this.httpClient
    .put(`${environment.api}/students`, student)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
    /* this.httpClient.put(this.API_URL + students.id, students).subscribe(data => {
      this.dialogData = students;
    },
    (err: HttpErrorResponse) => {
      // error code here
    }
  );*/
  }
  deleteStudents(student: Students): Observable<any> {
    //console.log("studentDelete:",student);
    return this.httpClient
    .post(`${environment.api}/students/delete`, student)
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
  GetAulas():Observable <any> {
    return  this.httpClient
    .get<any>(`${environment.api}/departments/`)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
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
