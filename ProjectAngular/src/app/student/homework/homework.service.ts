import { Injectable } from '@angular/core';
import { BehaviorSubject, map, Observable } from 'rxjs';
import { Homework } from './homework.modal';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { testHolland, testHollandDetails} from '../timetable/timetable.model';
@Injectable()
export class HomeworkService {
  
  
  
  private readonly API_URL = 'assets/data/stdHomework.json';

  dataChange: BehaviorSubject<Homework[]> = new BehaviorSubject<Homework[]>([]);
  // Temporarily stores data from dialogs
  dialogData: any;

  constructor(private httpClient: HttpClient) {}

  get data(): Homework[] {
    return this.dataChange.value;
  }

  getDialogData() {
    return this.dialogData;
  }

  /** CRUD METHODS */
  getAllIssues(): Observable<Homework[]> {
    return this.httpClient.get<Homework[]>(this.API_URL);
  }

  addIssue(homework: Homework): void {
    this.dialogData = homework;

    /*  this.httpClient.post(this.API_URL, homework).subscribe(data => {
      this.dialogData = homework;
      },
      (err: HttpErrorResponse) => {
     // error code here
    });*/
  }

  updateIssue(homework: Homework): void {
    this.dialogData = homework;

    /* this.httpClient.put(this.API_URL + homework.id, homework).subscribe(data => {
      this.dialogData = homework;
    },
    (err: HttpErrorResponse) => {
      // error code here
    }
  );*/
  }

  deleteIssue(id: number): void {
    //console.log(id);

    /*  this.httpClient.delete(this.API_URL + id).subscribe(data => {
      //console.log(id);
      },
      (err: HttpErrorResponse) => {
         // error code here
      }
    );*/
  }
  getAllCareers() : Observable<any>{
    return this.httpClient
        .get(`${environment.api}/studycareers`)
        .pipe(
          map((res : any) => {         
            
            return res.objModel;
          })
        );
  }
  getAllInstitutions() : Observable<any>{
    return this.httpClient
        .get(`${environment.api}/studyinstitutions`)
        .pipe(
          map((res : any) => {         
            
            return res.objModel;
          })
        );
  }
  InsertTest(testModel: testHolland) : Observable<any>{
    ////console.log("testModel", testModel)
    return this.httpClient
        .post(`${environment.api}/testholland`, testModel)
        .pipe(
          map((res : any) => { 
            return res.objModel;
          })
        );
  }
  Updatetest(testModel: testHolland) {
    return this.httpClient
    .put(`${environment.api}/testholland`, testModel)
    .pipe(
      map((res : any) => { 
        return res.objModel;
      })
    );
  }
  insertTestDetails(testDetails: testHollandDetails) : Observable<any>{
    return this.httpClient
    .post(`${environment.api}/testhollanddetails`, testDetails)
    .pipe(
      map((res : any) => { 
        return res.objModel;
      })
    );
  }
}
