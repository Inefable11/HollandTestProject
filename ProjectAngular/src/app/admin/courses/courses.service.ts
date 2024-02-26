import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { map, Observable } from 'rxjs';
import { testDetailRequestDTO } from '../courses/all-course/all-course.component';
import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';

@Injectable()
export class CoursesService {
 
    constructor(private httpClient: HttpClient){

    }
    GetTestDetail(req: testDetailRequestDTO): Observable<any> {
        return this.httpClient
        .post(`${environment.api}/testhollanddetails/GetTestDetail`, req)
        .pipe(
          map((res : any) => {         
            
            return res.objModel;
          })
        );
      }
      GetTestChart(testId: number): Observable<any> {
        ////console.log(`${environment.api}/testhollanddetails/GetTestChart/${testId}`)
        return this.httpClient
        .get(`${environment.api}/testhollanddetails/GetTestChart/${testId}`)
        .pipe(
          map((res : any) => {         
            
            return res.objModel;
          })
        );
      }
      getVocations(): Observable<any> {
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