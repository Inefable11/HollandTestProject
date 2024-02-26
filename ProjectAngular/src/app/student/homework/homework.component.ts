import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { HomeworkService } from './homework.service';
import { Homework, studyCareers, studyInstitutions } from './homework.modal';
import { UnsubscribeOnDestroyAdapter } from 'src/app/shared/UnsubscribeOnDestroyAdapter';
import { environment } from 'src/environments/environment';
import { MatDialog } from '@angular/material/dialog';
import { FormDialogCareersComponent } from './dialog/form-dialog-careers/form-dialog-careers.component';
import { FormDialogInstitutionsComponent } from './dialog/form-dialog-institutions/form-dialog-institutions.component';

@Component({
  selector: 'app-homework',
  templateUrl: './homework.component.html',
  styleUrls: ['./homework.component.css'],
})
export class HomeworkComponent
  extends UnsubscribeOnDestroyAdapter
  implements OnInit
{
  dataSource: MatTableDataSource<Homework>;
  dataLength: number;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  displayedColumns = [
    'class',
    'section',
    'subject',
    'homeworkDate',
    'submissionDate',
    'evalutionDate',
    'status',
  ];
  carrerasList:studyCareers[] = [];
  institucionesList: studyInstitutions[] = [];
  urlFoto= 'assets/images/user/';
  constructor(
    public httpClient: HttpClient,
    private homeworkService: HomeworkService,
    public dialog: MatDialog,
  ) {
    super();
  }

  ngOnInit() {
    this.loadData();
  }

  public loadData() {
    /*this.homeworkService = new HomeworkService(this.httpClient);
    this.subs.sink = this.homeworkService.getAllIssues().subscribe((data) => {
      this.dataSource = new MatTableDataSource(data);
      this.dataSource.data = data;
      this.dataLength = data.length;

      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });*/
    this.homeworkService.getAllCareers().subscribe(res =>{
      this.carrerasList = res;
      this.carrerasList.forEach(element => {
        if(element.jobProfile.length > 250){
          element.jobProfile = element.jobProfile.substring(0,250)+'...';
        }
      });
      console.log("carrerasList: ",this.carrerasList)
    })

    this.homeworkService.getAllInstitutions().subscribe(res =>{
      this.institucionesList = res;
      this.institucionesList.forEach(element => {
        if(element.description.length > 250){
          element.description = element.description.substring(0,250)+'...';
        }
        if(element.studyCareers.length > 91){
          element.studyCareers = element.studyCareers.substring(0,91)+'...';
        }
      });
      //console.log("institucionesList: ",this.institucionesList)
    })

  }

  /*applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }*/
  showDetail(carrera : studyCareers){
    ////console.log("carrera:", carrera)
    this.homeworkService.getAllCareers().subscribe(res=>{
      res.forEach(element => {
        if(carrera.id === element.id){
          const dialogRef = this.dialog.open(FormDialogCareersComponent, {
            data: {
              carrera: element,
              action: 'add',
            },
            width:'1050px',      
          });
        }
      });
    })
    

  }
  showDetailIns(instituciones : studyInstitutions){
    this.homeworkService.getAllInstitutions().subscribe(res=>{
      res.forEach(element => {
        if(instituciones.id === element.id){
          const dialogRef = this.dialog.open(FormDialogInstitutionsComponent, {
            data: {
              institution: element,
              action: 'add',
            },
            width:'1050px',  
           
          });
        }
      });
    })
  }
}
