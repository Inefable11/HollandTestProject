import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import {
  ChartComponent,
  ApexAxisChartSeries,
  ApexChart,
  ApexXAxis,
  ApexDataLabels,
  ApexTooltip,
  ApexYAxis,
  ApexPlotOptions,
  ApexStroke,
  ApexLegend,
  ApexFill,
} from 'ng-apexcharts';
import { FormDialogVocacionComponent } from 'src/app/student/leave-request/dialogs/form-dialog/form-dialog-vocacion/form-dialog-vocacion.component';
import { CoursesService } from '../courses.service';
export type areaChartOptions = {
  series: ApexAxisChartSeries;
  chart: ApexChart;
  xaxis: ApexXAxis;
  yaxis: ApexYAxis;
  stroke: ApexStroke;
  tooltip: ApexTooltip;
  dataLabels: ApexDataLabels;
  legend: ApexLegend;
  colors: string[];
};
export type barChartOptions = {
  series: ApexAxisChartSeries;
  chart: ApexChart;
  dataLabels: ApexDataLabels;
  plotOptions: ApexPlotOptions;
  yaxis: ApexYAxis;
  xaxis: ApexXAxis;
  fill: ApexFill;
  colors: string[];
};
@Component({
  selector: 'app-add-course',
  templateUrl: './add-course.component.html',
  styleUrls: ['./add-course.component.css']
})
export class AddCourseComponent implements OnInit {
  courseForm: FormGroup;
  public barChartOptions: Partial<barChartOptions>;
  dataPuntaje : number[] = [];
  vocacionesList: string[]=[];
  constructor(//private fb: FormBuilder,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public coursesService: CoursesService,
    public dialog: MatDialog,) {    
    //console.log("data: ", data)

  }
  ngOnInit(): void {
    this.vocacionesList = this.data.chart.personalityVocations.split(',');
    this.chart2();
  }
  onSubmit() {
    //console.log('Form Value', this.courseForm.value);
  }
  private chart2() {
    this.dataPuntaje.push(this.data.chart.scoreR);
    this.dataPuntaje.push(this.data.chart.scoreI);
    this.dataPuntaje.push(this.data.chart.scoreA);
    this.dataPuntaje.push(this.data.chart.scoreS);
    this.dataPuntaje.push(this.data.chart.scoreE);
    this.dataPuntaje.push(this.data.chart.scoreC);
    ////console.log('dataPuntaje', this.dataPuntaje);
    this.barChartOptions = {
      series: [
        {
          name: 'puntaje',
          data: this.dataPuntaje,
        },
      ],
      chart: {
        height: 320,
        type: 'bar',
        toolbar: {
          show: false,
        },
        foreColor: '#9aa0ac',
      },
      plotOptions: {
        bar: {
          dataLabels: {
            position: 'top', // top, center, bottom
          },
        },
      },
      dataLabels: {
        enabled: true,
        formatter: function (val) {
          return val + 'pts';
        },
        offsetY: -20,
        style: {
          fontSize: '12px',
          colors: ['#9aa0ac'],
        },
      },

      xaxis: {
        categories: [
          'Realista',
          'Investigador ',
          'Artístico',
          'Sociales',
          'Emprendedor',
          'Convencional',
        ],
        position: 'bottom',
        labels: {
          offsetY: 0,
        },
        axisBorder: {
          show: false,
        },
        axisTicks: {
          show: false,
        },
        crosshairs: {
          fill: {
            type: 'gradient',
            gradient: {
              colorFrom: '#D8E3F0',
              colorTo: '#BED1E6',
              stops: [0, 100],
              opacityFrom: 0.4,
              opacityTo: 0.5,
            },
          },
        },
        tooltip: {
          enabled: true,
          offsetY: -35,
        },
      },
      fill: {
        type: 'gradient',
        colors: ['#4F86F8', '#4F86F8'],
        gradient: {
          shade: 'light',
          type: 'horizontal',
          shadeIntensity: 0.25,
          gradientToColors: undefined,
          inverseColors: true,
          opacityFrom: 1,
          opacityTo: 1,
          stops: [50, 0, 100, 100],
        },
      },
      yaxis: {
        axisBorder: {
          show: false,
        },
        axisTicks: {
          show: false,
        },
        labels: {
          show: false,
          formatter: function (val) {
            return val + 'pts';
          },
        },
      },
    };
  }
  showVoc(voc){
    //console.log("vocacion:", voc)
    this.coursesService.getVocations().subscribe(res =>{
      let vocation = res.filter( x => x.vocation == voc);
      const dialogVoc = this.dialog.open(FormDialogVocacionComponent, {
        data:{
          vocacion:vocation
        }
      })
    })
    
  }


}
