import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { accessSystem, Staff } from './staff.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { UnsubscribeOnDestroyAdapter } from 'src/app/shared/UnsubscribeOnDestroyAdapter';
import { environment } from 'src/environments/environment';
@Injectable()
export class StaffService extends UnsubscribeOnDestroyAdapter {
  
   
  private readonly API_URL = 'assets/data/staff.json';
  isTblLoading = true;
  dataChange: BehaviorSubject<Staff[]> = new BehaviorSubject<Staff[]>([]);
  // Temporarily stores data from dialogs
  dialogData: any;
  AllStaffs: Staff[] = [];
  constructor(private httpClient: HttpClient) {
    super();
  }
  get data(): Staff[] {
    return this.dataChange.value;
  }
  getDialogData() {
    return this.dialogData;
  }
  /** CRUD METHODS */
  getAllStaffs(): void {
    this.subs.sink = this.httpClient.get<any>(`${environment.api}/staff`).subscribe(
      (data) => {
        this.isTblLoading = false;
        this.dataChange.next(data.objModel);
        this.AllStaffs = data.objModel;
        //console.log("AllStaffs", this.AllStaffs)
      },
      (error: HttpErrorResponse) => {
        this.isTblLoading = false;
        //console.log(error.name + ' ' + error.message);
      }
    );
  }

  addStaff(staff: Staff): void {
    this.dialogData = staff;

    /*  this.httpClient.post(this.API_URL, staff).subscribe(data => {
      this.dialogData = staff;
      },
      (err: HttpErrorResponse) => {
     // error code here
    });*/
  }
  insertStaff(staff: Staff, accessSystem: accessSystem, file: File): Observable<any> {
    const formData = new FormData(); 
    formData.append('file' , file);
    formData.append('staff', JSON.stringify(staff));
    formData.append('accessSystem', JSON.stringify(accessSystem));
    //console.log("file", file)
    return this.httpClient
    .post(`${environment.api}/staff/insertStaff`, formData)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );
  } 
  updateStaff(staff: Staff): Observable<any> {
    this.dialogData = staff;
    return this.httpClient
    .put(`${environment.api}/staff`, staff)
    .pipe(
      map((res : any) => {         
        
        return res.objModel;
      })
    );

    /* this.httpClient.put(this.API_URL + staff.id, staff).subscribe(data => {
      this.dialogData = staff;
    },
    (err: HttpErrorResponse) => {
      // error code here
    }
  );*/
  }
  deleteStaff(staff): Observable<any> {
    //console.log(staff.id);
    return this.httpClient
    .post(`${environment.api}/staff/delete`, staff)
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
