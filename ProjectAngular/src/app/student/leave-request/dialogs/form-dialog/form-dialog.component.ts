import { MAT_DIALOG_DATA, MatDialogRef, MatDialog } from '@angular/material/dialog';
import { Component, Inject, OnInit } from '@angular/core';
import { LeaveRequestService } from '../../leave-request.service';
import {
  FormControl,
  Validators,
  FormGroup,
  FormBuilder,
} from '@angular/forms';
import { LeaveRequest } from '../../leave-request.model';
import { MAT_DATE_LOCALE } from '@angular/material/core';
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
import { FormDialogVocacionComponent } from './form-dialog-vocacion/form-dialog-vocacion.component';
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
  selector: 'app-form-dialog',
  templateUrl: './form-dialog.component.html',
  styleUrls: ['./form-dialog.component.css'],
  providers: [{ provide: MAT_DATE_LOCALE, useValue: 'en-GB' }],
})
export class FormDialogComponent  implements OnInit {
  action: string;
  dialogTitle: string;
  leaveRequestForm: FormGroup;
  leaveRequest: LeaveRequest;
  public barChartOptions: Partial<barChartOptions>;
  dataPuntaje : number[] = [];
  vocacionesList: string[]=[];
  constructor(
    public dialogRef: MatDialogRef<FormDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
    public leaveRequestService: LeaveRequestService,
    private fb: FormBuilder,
    public dialog: MatDialog,
  ) {
    // Set the defaults
    
    this.data.chart.personalityDescription = this.data.chart.personalityDescription.replace('\n\r','<br>');
    console.log("data", data) 
    this.action = data.action;
    if (this.action === 'edit') {
      this.dialogTitle = 'Edit Leave Request';
      this.leaveRequest = data.leaveRequest;
    } else {
      this.dialogTitle = 'New Leave Request';
      this.leaveRequest = new LeaveRequest({});
    }
    this.leaveRequestForm = this.createContactForm();
  }
  ngOnInit(): void {
    this.vocacionesList = this.data.chart.personalityVocations.split(',');
    //console.log("vocaciones: ", this.vocacionesList)
    this.chart2();
  }
  formControl = new FormControl('', [
    Validators.required,
    // Validators.email,
  ]);
  getErrorMessage() {
    return this.formControl.hasError('required')
      ? 'Required field'
      : this.formControl.hasError('email')
      ? 'Not a valid email'
      : '';
  }
  createContactForm(): FormGroup {
    return this.fb.group({
      id: [this.leaveRequest.id],
      class: [this.leaveRequest.className, [Validators.required]],
      section: [this.leaveRequest.dateStart, [Validators.required]],
      applyDate: [this.leaveRequest.timeWork, [Validators.required]],
      fromDate: [this.leaveRequest.status, [Validators.required]],
    });
  }
  submit() {
    // emppty stuff
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  public confirmAdd(): void {
    this.leaveRequestService.addLeaveRequest(
      this.leaveRequestForm.getRawValue()
    );
  }

  private chart2() {
    this.dataPuntaje.push(this.data.chart.scoreR);
    this.dataPuntaje.push(this.data.chart.scoreI);
    this.dataPuntaje.push(this.data.chart.scoreA);
    this.dataPuntaje.push(this.data.chart.scoreS);
    this.dataPuntaje.push(this.data.chart.scoreE);
    this.dataPuntaje.push(this.data.chart.scoreC);
   
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
    this.leaveRequestService.getVocations().subscribe(res =>{
      let vocation = res.filter( x => x.vocation == voc);
      const dialogVoc = this.dialog.open(FormDialogVocacionComponent, {
        data:{
          vocacion:vocation
        }
      })
    })
    
  }
}
