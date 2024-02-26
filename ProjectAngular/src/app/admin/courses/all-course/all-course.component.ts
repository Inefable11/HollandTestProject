import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { environment } from 'src/environments/environment';
import { AddCourseComponent } from '../add-course/add-course.component';
import { CoursesService } from '../courses.service';


@Component({
  selector: 'app-all-course',
  templateUrl: './all-course.component.html',
  styleUrls: ['./all-course.component.sass']
})
export class AllCourseComponent implements OnInit {
  proForm: FormGroup;
  response : testDetailResponse[]=[];
  urlFoto= environment.urlFoto;
  constructor(private fb: FormBuilder,
    private coursesService: CoursesService,
    public dialog: MatDialog,) { 
    this.proForm = this.createContactForm();
  }
  createContactForm(): FormGroup {
    return this.fb.group({
      textSearch: [''],
      idate: [''],
      fdate: ['']
    });
  }

  ngOnInit(): void {
    this.refresh();
  }
  refresh() {
    /*if(this.proForm.value.fdate > this.proForm.value.idate){
      window.alert("La fecha final no debe ser mayor a la inicial");
      this.proForm.reset();
      return;

    }*/
    //console.log("refresh", this.proForm.value)
    let req : testDetailRequestDTO = {
      name: this.proForm.value.textSearch,
      fechaResolucionIni: this.proForm.value.idate == ''? null : this.proForm.value.idate,
      fechaResolucionFin: this.proForm.value.idate == ''? null : this.proForm.value.idate,
    }
    //console.log("req", req)
    this.coursesService.GetTestDetail(req).subscribe(res =>{
      this.response = res;

      //console.log("response:", this.response) ;      
    }); 
  }
  submit() {
    //console.log("submit")
  }
  showTest(test:testDetailResponse){
    this.coursesService.GetTestChart(test.testId).subscribe(res =>{
      //console.log(res)
      const dialogRef = this.dialog.open(AddCourseComponent, {
        data: {
          test: test,
          chart: res,
          action: 'add',
        },
        width:'950px',
        height:'100%',
        direction: 'ltr',
      });
    })
    
  }
}
export interface testDetailRequestDTO {
  name: string;
  fechaResolucionIni: Date | null;
  fechaResolucionFin: Date | null;
}
export interface testDetailResponse {
  name: string;
  img: string;
  timeElapsed: number;
  personality: string;
  personalityVocations: string;
  fechaResolucion: string;
  testId: number;
}