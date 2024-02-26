import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { Department } from './department.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { UnsubscribeOnDestroyAdapter } from 'src/app/shared/UnsubscribeOnDestroyAdapter';
import { environment } from 'src/environments/environment';
@Injectable()
export class DepartmentService extends UnsubscribeOnDestroyAdapter {
  private readonly API_URL = 'assets/data/department.json';
  isTblLoading = true;
  dataChange: BehaviorSubject<Department[]> = new BehaviorSubject<Department[]>(
    []
  );
  // Temporarily stores data from dialogs
  dialogData: any;
  constructor(private httpClient: HttpClient) {
    super();
  }
  get data(): Department[] {
    return this.dataChange.value;
  }
  getDialogData() {
    return this.dialogData;
  }
  /** CRUD METHODS */
  getAllDepartments(): void {
    this.subs.sink = this.httpClient
    .get<any>(`${environment.api}/departments`).subscribe(
      (data) => {
        this.isTblLoading = false;
        this.dataChange.next(data.objModel);
        //console.log("departments",data.objModel)
      },
      (error: HttpErrorResponse) => {
        this.isTblLoading = false;
        //console.log(error.name + ' ' + error.message);
      }
      
    );
  }
  addDepartment(department: Department): Observable<any> {
    this.dialogData = department;
    return this.httpClient
    .post(`${environment.api}/departments`, department)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );

    /*  this.httpClient.post(this.API_URL, department).subscribe(data => {
      this.dialogData = department;
      },
      (err: HttpErrorResponse) => {
     // error code here
    });*/
  }
  updateDepartment(department: Department): Observable<any> {
    this.dialogData = department;
    return this.httpClient
    .put(`${environment.api}/departments`, department)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );

    /* this.httpClient.put(this.API_URL + department.id, department).subscribe(data => {
      this.dialogData = department;
    },
    (err: HttpErrorResponse) => {
      // error code here
    }
  );*/
  }
  deleteDepartment(department: Department): Observable<any> {
    //console.log(department.id);
    return this.httpClient
    .post(`${environment.api}/departments/delete`, department)
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
  GetParameter(id: number) :Observable <any>  {
    return  this.httpClient
    .get<any>(`${environment.api}/parameterdetails/GetParameter/` + id)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );    
  }
  getAllTeachers():Observable <any> {
    return  this.httpClient
    .get<any>(`${environment.api}/teachers`)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );     
  }
}
