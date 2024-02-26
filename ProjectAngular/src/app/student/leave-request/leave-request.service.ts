import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { LeaveRequest } from './leave-request.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { UnsubscribeOnDestroyAdapter } from 'src/app/shared/UnsubscribeOnDestroyAdapter';
import { environment } from 'src/environments/environment';
@Injectable()
export class LeaveRequestService extends UnsubscribeOnDestroyAdapter {
  
  
  private readonly API_URL = 'assets/data/stdLeaveReq.json';
  isTblLoading = true;
  dataChange: BehaviorSubject<LeaveRequest[]> = new BehaviorSubject<
    LeaveRequest[]
  >([]);
  // Temporarily stores data from dialogs
  dialogData: any;
  constructor(private httpClient: HttpClient) {
    super();
  }
  get data(): LeaveRequest[] {
    return this.dataChange.value;
  }
  getDialogData() {
    return this.dialogData;
  }
  /** CRUD METHODS */
  getAllLeaveRequests(id : number): void {
    
    this.subs.sink = this.httpClient
    .get<any>(`${environment.api}/teachers/GetTeacherGrid`).subscribe(
      (data) => {
        console.log("dataModel", data.objModel)
        this.isTblLoading = false;
        const dataModel = data.objModel.filter(x => x.idStudent==id)
        this.dataChange.next(dataModel);   
        /*this.AllTeachers = data.objModel;
        console.log("AllTeachers", this.AllTeachers)*/
        console.log("dataModelFilter", dataModel)
      },
      (error: HttpErrorResponse) => {
        this.isTblLoading = false;
        //console.log(error.name + ' ' + error.message);
      }
      
    );
  }
  addLeaveRequest(leaveRequest: LeaveRequest): void {
    this.dialogData = leaveRequest;

    /*  this.httpClient.post(this.API_URL, leaveRequest).subscribe(data => {
      this.dialogData = leaveRequest;
      },
      (err: HttpErrorResponse) => {
     // error code here
    });*/
  }
  updateLeaveRequest(leaveRequest: LeaveRequest): void {
    this.dialogData = leaveRequest;

    /* this.httpClient.put(this.API_URL + leaveRequest.id, leaveRequest).subscribe(data => {
      this.dialogData = leaveRequest;
    },
    (err: HttpErrorResponse) => {
      // error code here
    }
  );*/
  }
  deleteLeaveRequest(id: number): void {
    //console.log(id);

    /*  this.httpClient.delete(this.API_URL + id).subscribe(data => {
      //console.log(id);
      },
      (err: HttpErrorResponse) => {
         // error code here
      }
    );*/
  }
  GetTestChart(id: number): Observable<any> {
    return this.httpClient
    .get(`${environment.api}/testhollanddetails/GetTestChart/${id}`)
    .pipe(
      map((res : any) => {         
        //console.log("objModel", res.objModel)
        return res.objModel;
      })
    );
  }
  getVocations(): Observable<any>  {
    return this.httpClient
    .get(`${environment.api}/vocations/`)
    .pipe(
      map((res : any) => {         
        //console.log("objModel", res.objModel)
        return res.objModel;
      })
    );
  }
}
