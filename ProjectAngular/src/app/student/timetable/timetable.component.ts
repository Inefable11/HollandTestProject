import { DatePipe, DOCUMENT } from '@angular/common';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import * as moment from 'moment';
import { AuthService } from 'src/app/core/service/auth.service';
import { UnsubscribeOnDestroyAdapter } from 'src/app/shared/UnsubscribeOnDestroyAdapter';
import { HomeworkService } from '../homework/homework.service';
import { FormDialogComponent } from '../timetable/form-dialog/form-dialog.component';
import { testHolland, testHollandDetails } from './timetable.model';


@Component({
  selector: 'app-timetable',
  templateUrl: './timetable.component.html',
  styleUrls: ['./timetable.component.css']
})
export class TimetableComponent  extends UnsubscribeOnDestroyAdapter implements OnInit {
  isLinear = false;
  image:string;
  HFormGroup1: FormGroup;
  HFormGroup2: FormGroup;
  formTabla: FormGroup;
  formTabla1: FormGroup;
  formTabla2: FormGroup;
  formTabla3: FormGroup;
  formTabla4: FormGroup;
  formTabla5: FormGroup;
  formTabla6: FormGroup;
  testModel:testHolland;
  tetxHeader:string='Tabla 1: '
  table1Preg1:boolean =false;
  table1Preg2:boolean =false;
  table1Preg3:boolean =false;
  table1Preg4:boolean =false;
  table1Preg5:boolean =false;
  table1Preg6:boolean =false;
  table1Preg7:boolean =false;
  table1Preg8:boolean =false;
  table1Preg9:boolean =false;
  table2Preg1:boolean =false;
  table2Preg2:boolean =false;
  table2Preg3:boolean =false;
  table2Preg4:boolean =false;
  table2Preg5:boolean =false;
  table2Preg6:boolean =false;
  table2Preg7:boolean =false;
  table2Preg8:boolean =false;
  table2Preg9:boolean =false;
  table3Preg1:boolean =false;
  table3Preg2:boolean =false;
  table3Preg3:boolean =false;
  table3Preg4:boolean =false;
  table3Preg5:boolean =false;
  table3Preg6:boolean =false;
  table3Preg7:boolean =false;
  table3Preg8:boolean =false;
  table3Preg9:boolean =false;
  table4Preg1:boolean =false;
  table4Preg2:boolean =false;
  table4Preg3:boolean =false;
  table4Preg4:boolean =false;
  table4Preg5:boolean =false;
  table4Preg6:boolean =false;
  table4Preg7:boolean =false;
  table4Preg8:boolean =false;
  table4Preg9:boolean =false;
  table5Preg1:boolean =false;
  table5Preg2:boolean =false;
  table5Preg3:boolean =false;
  table5Preg4:boolean =false;
  table5Preg5:boolean =false;
  table5Preg6:boolean =false;
  table5Preg7:boolean =false;
  table5Preg8:boolean =false;
  table5Preg9:boolean =false;
  table6Preg1:boolean =false;
  table6Preg2:boolean =false;
  table6Preg3:boolean =false;
  table6Preg4:boolean =false;
  table6Preg5:boolean =false;
  table6Preg6:boolean =false;
  table6Preg7:boolean =false;
  table6Preg8:boolean =false;
  table6Preg9:boolean =false;
  boolArray:any[]=[
    {"name":'showTimer',"prop":false},
    {"name":'boolTable1_1',"prop":false},
    {"name":'boolTable1_2',"prop":true},
    {"name":'boolTable1_3',"prop":true},
    {"name":'boolTable1_4',"prop":true},
    {"name":'boolTable1_5',"prop":true},
    {"name":'boolTable1_6',"prop":true},
    {"name":'boolTable1_7',"prop":true},
    {"name":'boolTable1_8',"prop":true},
    {"name":'boolTable1_9',"prop":true},
    {"name":'boolTable1_10',"prop":true},
    {"name":'boolTable1_11',"prop":true},
    {"name":'boolTable1_12',"prop":true},
    {"name":'boolTable1_13',"prop":true},
    {"name":'boolTable1_14',"prop":true},
    {"name":'boolTable1_15',"prop":true},
    {"name":'boolTable1_16',"prop":true},
    {"name":'boolTable1_17',"prop":true},
    {"name":'boolTable1_18',"prop":true},
  ]
  
  seasons: string[] = ['Galaxia', 'Mariposa', 'Wonder World', 'Lectura'];
  audios:any[] = [{"name":"Musica 1", "audio":"assets/music/Quizizz Synthwave music extended.mp3"},
                  {"name":"Música 2", "audio":"assets/music/Quizizz Theme Song 1 hour.mp3"},
                  {"name":"Música 3", "audio":"assets/music/Música De Fondo Para Videos.mp3"}]
  favoriteSeason: string;
  elem:any;
  _color:any;
  private _idtestHolland: number;
  horaInicio: any;
  horaFin: string;
  personality: string = '';
  personalityDescription: string = '';
  personalityVocations: string = '';
  fechaInicio = moment(new Date());
  constructor(private _formBuilder: FormBuilder,
    public datepipe: DatePipe,
    private service: HomeworkService,
    private router: Router,
    private authService: AuthService,
    public dialog: MatDialog,
    @Inject(DOCUMENT) private document: any,) {
    super();
  }

  ngOnInit(): void {  
    
    this.elem = document.documentElement;
    this.image='assets/images/pages/ganev.jpeg';  
    this.formTabla  = this._formBuilder.group({
      
    }); 
    this.formTabla1 = this._formBuilder.group({
      table1Preg1: [''],
      table1Preg2: [''],
      table1Preg3: [''],
      table1Preg4: [''],
      table1Preg5: [''],
      table1Preg6: [''],
      table1Preg7: [''],
      table1Preg8: [''],
      table1Preg9: [''],     
    });
    this.formTabla2 = this._formBuilder.group({
      table2Preg1: [''],
      table2Preg2: [''],
      table2Preg3: [''],
      table2Preg4: [''],
      table2Preg5: [''],
      table2Preg6: [''],
      table2Preg7: [''],
      table2Preg8: [''],
      table2Preg9: [''],     
    });
    this.formTabla3 = this._formBuilder.group({
      table3Preg1: [''],
      table3Preg2: [''],
      table3Preg3: [''],
      table3Preg4: [''],
      table3Preg5: [''],
      table3Preg6: [''],
      table3Preg7: [''],
      table3Preg8: [''],
      table3Preg9: [''],     
    });
    this.formTabla4 = this._formBuilder.group({
      table4Preg1: [''],
      table4Preg2: [''],
      table4Preg3: [''],
      table4Preg4: [''],
      table4Preg5: [''],
      table4Preg6: [''],
      table4Preg7: [''],
      table4Preg8: [''],
      table4Preg9: [''],     
    });
    this.formTabla5 = this._formBuilder.group({
      table5Preg1: [''],
      table5Preg2: [''],
      table5Preg3: [''],
      table5Preg4: [''],
      table5Preg5: [''],
      table5Preg6: [''],
      table5Preg7: [''],
      table5Preg8: [''],
      table5Preg9: [''],     
    });
    this.formTabla6 = this._formBuilder.group({
      table6Preg1: [''],
      table6Preg2: [''],
      table6Preg3: [''],
      table6Preg4: [''],
      table6Preg5: [''],
      table6Preg6: [''],
      table6Preg7: [''],
      table6Preg8: [''],
      table6Preg9: [''],     
    });
   ////console.log("bb", this.boolArray[0].prop)
  }
  openDialog(testHollandDetails : testHollandDetails) {
    let tempDirection
     let currentUser : any =JSON.parse(localStorage.getItem('currentUser')) 
    const dialogRef = this.dialog.open(FormDialogComponent, {
      data: {
        currentUser:currentUser,
        action: 'add',
      },
      direction: tempDirection,
    });
    this.subs.sink = dialogRef.afterClosed().subscribe((result)=>{
      //console.log ("testHollandDetails:", testHollandDetails)
      this.service.insertTestDetails(testHollandDetails).subscribe(res=>{
        this.router.navigate(['/student/leave-request']);
      })
    })
  }
  showDate(){    
    
  }
  startTest(action: boolean, control : string){
    switch (control) {
      case 'showTimer':
        {
          this.boolArray.forEach(element => {
          let index = this.boolArray.indexOf(element)
          ////console.log("element", element)
          if(element.name == 'showTimer'){
            this.boolArray[index].prop= true;
          }
        });
        //this.showTimer = action;
      }
        break;
    
      default:
        break;
    }
    
    let currentUser : any =JSON.parse(localStorage.getItem('currentUser'))
    this.horaInicio = new Date().getHours() + ':' + new Date().getMinutes() + ':' + new Date().getSeconds();
    this.testModel={
      id: 0,
      idStudent: currentUser.id,
      fechaAsignacion: new Date(),
      fechaResolucion: new Date(), 
      horaInicio: this.horaInicio,
      horaFin: ''
    }
    this.service.InsertTest(this.testModel).subscribe(res =>{
      this._idtestHolland = res;
      ////console.log("idtestHolland: ", this._idtestHolland)
     

    })    
    
  }

  chageImage(event : string){
    this.elem.requestFullscreen();
    ////console.log("imagen", event)
    if(event == 'Galaxia'){
      this.image='assets/images/pages/galaxy.jpeg';
    }else if(event == 'Mariposa'){
      this.image='assets/images/pages/fly.jpeg';
    }else if(event == 'Wonder World'){
      this.image='assets/images/pages/skyworld.jpeg';
    }else if(event == 'Lectura'){
      this.image='assets/images/pages/fire.jpeg';
    }/*else if(event == 'Inicial'){
      this.image='https://wallpapercave.com/wp/wp2758145.gif';
    } */
  }  
  submitForm(form1 : any, form2 : any, form3 : any, form4 : any, form5 : any, form6 : any){   
    this.horaFin = new Date().getHours() + ':' + new Date().getMinutes() + ':' + new Date().getSeconds();
    this.testModel.id = this._idtestHolland;
    this.testModel.horaFin = this.horaFin;
    this.service.Updatetest(this.testModel).subscribe(res =>{

    })
    /*//console.log ("form1:", form1.value)
    //console.log ("form2:", form2.value)
    //console.log ("form3:", form3.value)
    //console.log ("form4:", form4.value)
    //console.log ("form5:", form5.value)
    //console.log ("form6:", form6.value)*/
    let scores : any[]=[];
    let _scoreC : number = 0;
    Object.keys(form1.value).map((key)=>{
      /*//console.log(key);
      //console.log(form1.value[key]);*/
      if(form1.value[key] == true){
        _scoreC++;
      }
    })
    scores.push({name:'scoreC', value: _scoreC});
    let _scoreR : number = 0;
    Object.keys(form2.value).map((key)=>{
      /*//console.log(key);
      //console.log(form1.value[key]);*/
      if(form2.value[key] == true){
        _scoreR++;
      }
    })  
    scores.push({name:'scoreR', value: _scoreR}); 
    let _scoreI : number = 0;
    Object.keys(form3.value).map((key)=>{
      /*//console.log(key);
      //console.log(form1.value[key]);*/
      if(form3.value[key] == true){
        _scoreI++;
      }
    })   
    scores.push({name:'scoreI', value: _scoreI}); 
    let _scoreE : number = 0;
    Object.keys(form4.value).map((key)=>{
      /*//console.log(key);
      //console.log(form1.value[key]);*/
      if(form4.value[key] == true){
        _scoreE++;
      }
    })  
    scores.push({name:'scoreE', value: _scoreE});  
    let _scoreS : number = 0;
    Object.keys(form5.value).map((key)=>{
      /*//console.log(key);
      //console.log(form1.value[key]);*/
      if(form5.value[key] == true){
        _scoreS++;
      }
    })  
    scores.push({name:'scoreS', value: _scoreS});   
    let _scoreA : number = 0;
    Object.keys(form6.value).map((key)=>{
      /*//console.log(key);
      //console.log(form1.value[key]);*/
      if(form6.value[key] == true){
        _scoreA++;
      }
    })
    scores.push({name:'scoreA', value: _scoreA});  
    scores = scores.sort(function (a, b) {
      if (a.value > b.value) {
        return 1;
      }
      if (a.value < b.value) {
        return -1;
      }
      // a must be equal to b
      return 0;
    });
    
    let order : number =5;
    for (let index = 0; index < 3; index++) {
      switch (scores[order].name) {
        case 'scoreR':         
          this.personalityDescription= this.personalityDescription + '\n\r Realista: Este ambiente incluye personas que se destacan por sus capacidades mecánicas y deportivas. Prefieren trabajar con maquinaria, equipamiento, plantas y animales. Es posible que también les guste trabajar fuera de una oficina. '+
                                      '\n\r Capacidades Motivacionales: Realizar cosas de manera concreta, hacer objetos o a ejercer una actividad que implica el uso de sus manos o de herramientas y técnicas manuales. Voluntad de no contentarse de una función intelectual y puramente conceptual.'+
                                      '\n\r Intereses, Valores: Involucra la necesidad implicación física en su trabajo, lejos dela pasividad de la oficina, y/o la necesidad de ejercer una actividad al aire libre o permitiendo conservar un lazo estrecho con la naturaleza. '+
                                      '\n\r Lo Que Evita:La pasividad y dejar que otros resuelvan asuntos que él mismo puede desarrollar. ';
          if(index == 0){
            this.personality = 'Realista'
            this.personalityVocations= 'La agricultura,el medio ambiente,empleo en la industria sobre una cadena de producción,puesto de instalador,reparador informático,administrador como informático,redes'
          }else{
            this.personality = this.personality +' - Realista'
            this.personalityVocations= this.personalityVocations + '\n\r ,La agricultura,el medio ambiente,empleo en la industria sobre una cadena de producción,puesto de instalador,reparador informático,administrador como informático,redes'
          }
         
          break;
        case 'scoreI':
          
          this.personalityDescription= this.personalityDescription + '\n\r Investigador: Este ambiente representa a los que prefieren profesiones científicas e intelectuales. Disfrutan de reunir información, identificar teorías o hechos y analizar e interpretar información. '+
                                      '\n\r Capacidades Motivacionales: Desarrollar y valorar competencias, aconsejar a individuos o a empresas sobre estas áreas, investigar, transmitir conocimiento. '+
                                      '\n\r Intereses, Valores: La tecnicidad, la  precisión, la  profesionalidad,  el rigor y el  sentido del  detalle, la  enseñanza, las ciencias, los métodos  novedosos. '+
                                      '\n\r Lo Que Evita: La falta de profesionalismo, la imprecisión, la incompetencia, la cotidianidad, la subjetividad. ';
          if(index == 0){
            this.personality = 'Investigador'
            this.personalityVocations= 'Desarrollo informático,venta de soluciones técnicas,análisis financiero,contabilidad,búsqueda científica,formación,consejo';
          }else{
            this.personality = this.personality +' - Investigador'
            this.personalityVocations= this.personalityVocations + ',Desarrollo informático,venta de soluciones técnicas,análisis financiero,contabilidad,búsqueda científica,formación,consejo';
          }
          
          break;
          case 'scoreA':            
            this.personalityDescription= this.personalityDescription + '\n\r Artístico: Este ambiente incluye a las personas que aprecian las cualidades estéticas que expresan a través de su trabajo artístico y literario. Se caracterizan por su flexibilidad y no conformidad o compromiso con un sistema específico. '+
                                      '\n\r Capacidades Motivacionales: Concebir, redactar, razonar por analogía, dibujar, imaginar, percibir, innovar, debatir, cuestionar el conformismo. '+
                                      '\n\r Intereses, Valores: Los símbolos, el futuro, la originalidad, los conceptos y su concreción, la estética, las emociones y su representación. '+
                                      '\n\r Lo Que Evita: La rutina, el conformismo, el no debatir ideas, los prejuicios, las actividades de cálculo, la técnica y las ciencias, las actividades físicas. ';
            if(index == 0){
              this.personality=this.personality +'Artístico'
              this.personalityVocations= 'Artista,grafista,arquitecto,jefe de proyecto multimedia,marketing y publicidad'; 
            }else{
              this.personality=this.personality +' - Artístico'
              this.personalityVocations= this.personalityVocations +  ',Artista,grafista,arquitecto,jefe de proyecto multimedia,marketing y publicidad'; 
            }
            
            break;
        case 'scoreS':
          
          this.personalityDescription= this.personalityDescription + '\n\r Social: Este ambiente está representado por personas sociales que disfrutan al ayudar a otros. Prefieren trabajar en grupos y se caracterizan también por sus grandes habilidades de comunicación. '+
                                      '\n\r Capacidades Motivacionales: Explicar, seducir, negociar, presentar, aconsejar y vender, tener contactos, comunicar con los clientes o internamente. Ayudar a los otros, prestar servicio, escuchar, informar, formar, ayudar a cada uno a progresar, aconsejar y orientar. '+
                                      '\n\r Intereses, Valores: Las buenas relaciones, los viajes y las otras culturas, las negociaciones, el ambiente de trabajo.  La empatía, las relaciones humanas, el bienestar personal, la psicología, la medicina, el humanismo, la justicia. '+
                                      '\n\r Lo Que Evita: La ausencia de contactos con el entorno exterior, el trabajo solitario. El mercantilismo, el individualismo, el hecho de no hacer nada por mejorar la vida de los otros.';
          if(index == 0){
            this.personality='Social'
            this.personalityVocations= 'Encargado/a de clientela,soporte de ventas,comunicación y relaciones públicas,Profesor/a,psicólogo/a,responsable de formación,servicio post- venta,recursos humanos';
          }else{
            this.personality=this.personality +' - Social'
            this.personalityVocations= this.personalityVocations +  ',Encargado/a de clientela,soporte de ventas,comunicación y relaciones públicas,Profesor/a,psicólogo/a,responsable de formación,servicio post- venta,recursos humanos';
          }
          
          break;
          case 'scoreE':
           
            this.personalityDescription= this.personalityDescription + '\n\r Emprendedor: Este ambiente incluye a las personas con personalidad administrativa. Pueden conectar eficientemente sus ideas y opiniones con los demás y persuadirlos. Además, confían mucho en sí mismos y tienen la energía necesaria para lograr sus aspiraciones. '+
                                        '\n\r Capacidades Motivacionales: Animar una reunión, supervisar, motivar a los colaboradores, manejar conflictos, reconciliar, convencer, planear las acciones, decidir y cortar. Improvisar, gestionarlas urgencias, ir sobre el terreno, desarrollar nuevas actividades, materializar proyectos o ideas, conseguir ventas, lanzar desafíos.'+
                                        '\n\r Intereses, Valores: El management, las orientaciones estratégicas, la dirección de proyectos.  La acción a corto plazo, la aventura, la toma de riesgos, los negocios y el beneficio, las nuevas modas. '+
                                        '\n\r Lo Que Evita:La ausencia de responsabilidades, la imposibilidad de tomar decisiones, supervisores demasiado controladores. La inmovilidad y la inacción, trabajar encerrado en un despacho, la falta de iniciativa. ';
            if(index == 0){
              this.personality='Emprendedor'
              this.personalityVocations= 'Manager,jefe de ventas,recursos humanos,dirección financiera,relaciones públicas,Comercial,marketing operacional,compras,distribución,logística,desarrollo de proyectos o negocios,dirección de PYME';
            }else{
              this.personality=this.personality +' - Emprendedor'
              this.personalityVocations= this.personalityVocations +  ',Manager,jefe de ventas,recursos humanos,dirección financiera,relaciones públicas,Comercial,marketing operacional,compras,distribución,logística,desarrollo de proyectos o negocios,dirección de PYME';
            }            
        break;
        case 'scoreC':
          
          this.personalityDescription= this.personalityDescription + '\n\r Convencional: Incluye a las personas con un alto grado de control y que prefieren trabajar con números y cifras. Son precisos en su trabajo y siempre cumplen las normas, leyes y reglamentos laborales. '+
                                      '\n\r Capacidades Motivacionales: Organizar, planificar rigurosamente las actividades, aplicar métodos o reglas de gestión, controlar la calidad, estructurar y clasificar la información. '+
                                      '\n\r Intereses, Valores: La informática, las reglas y las convenciones, los métodos, la anticipación de acontecimientos, el cuidado del detalle, la eficacia. '+
                                      '\n\r Lo Que Evita:El cambio inopinado, la improvisación frente a situaciones importantes, la falta de métodos o medios. ';      
          if(index == 0){
            this.personality='Convencional'
            this.personalityVocations='Informática,gestión de producción,pre-venta,consejo en organización,control de gestión,finanzas,contabilidad,jurídico';
          }else{
            this.personality=this.personality +' - Convencional'
            this.personalityVocations= this.personalityVocations +  ',Informática,gestión de producción,pre-venta,consejo en organización,control de gestión,finanzas,contabilidad,jurídico';
          }
          
          break;
               
        default:
          break;
      } 
      order--;
    }
  
    let fechaFin = moment(new Date());
    var _timeElapsed = fechaFin.diff(this.fechaInicio, 'm');
    //console.log(_timeElapsed);
    let testHollandDetails : testHollandDetails ={
      id: 0,
      idtestHolland: this._idtestHolland,
      scoreR: _scoreR,
      scoreI: _scoreI,
      scoreA: _scoreA,
      scoreS: _scoreS,
      scoreE: _scoreE,
      scoreC: _scoreC,
      timeElapsed:_timeElapsed,
      personality: this.personality,
      personalityDescription: this.personalityDescription,
      personalityVocations: this.personalityVocations
    }
    this.openDialog(testHollandDetails);
     
     ////console.log ("scores:", scores)       
  }
  Next(name:string){
    switch (name) {
      case 'boolTable1_1':
        {
          this.boolArray.forEach(element => {
          let index = this.boolArray.indexOf(element)
          ////console.log("element", element)
          if(element.name == 'boolTable1_1'){
            this.boolArray[index].prop= false;
          }else{
            this.boolArray[index].prop= true;
          }
        });
        //this.showTimer = action;
      }
        break;
      case 'boolTable1_2':
        {
          this.boolArray.forEach(element => {
          let index = this.boolArray.indexOf(element)
          ////console.log("element", element)
          if(element.name == 'boolTable1_2'){
            this.boolArray[index].prop= false;
          }else{
            this.boolArray[index].prop= true;
          }
        });
        //this.showTimer = action;
      }
        break;
      case 'boolTable1_3':
      {
      this.boolArray.forEach(element => {
      let index = this.boolArray.indexOf(element)
      ////console.log("element", element)
      if(element.name == 'boolTable1_3'){
      this.boolArray[index].prop= false;
      }else{
      this.boolArray[index].prop= true;
      }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_4':
      {
      this.tetxHeader='Tabla 2: '
      this.boolArray.forEach(element => {
      let index = this.boolArray.indexOf(element)
      ////console.log("element", element)
      if(element.name == 'boolTable1_4'){
        this.boolArray[index].prop= false;
      }else{
        this.boolArray[index].prop= true;
      }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_5':
      {
        this.boolArray.forEach(element => {
        let index = this.boolArray.indexOf(element)
        ////console.log("element", element)
        if(element.name == 'boolTable1_5'){
          this.boolArray[index].prop= false;
        }else{
          this.boolArray[index].prop= true;
        }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_6':
      {
        this.boolArray.forEach(element => {
        let index = this.boolArray.indexOf(element)
        ////console.log("element", element)
        if(element.name == 'boolTable1_6'){
          this.boolArray[index].prop= false;
        }else{
          this.boolArray[index].prop= true;
        }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_7':
        {
          this.tetxHeader='Tabla 3: '
          this.boolArray.forEach(element => {
          let index = this.boolArray.indexOf(element)
          ////console.log("element", element)
          if(element.name == 'boolTable1_7'){
            this.boolArray[index].prop= false;
          }else{
            this.boolArray[index].prop= true;
          }
        });
        //this.showTimer = action;
      }
        break;
      case 'boolTable1_8':
        {
          this.boolArray.forEach(element => {
          let index = this.boolArray.indexOf(element)
          ////console.log("element", element)
          if(element.name == 'boolTable1_8'){
            this.boolArray[index].prop= false;
          }else{
            this.boolArray[index].prop= true;
          }
        });
        //this.showTimer = action;
      }
        break;
      case 'boolTable1_9':
      {
      this.boolArray.forEach(element => {
      let index = this.boolArray.indexOf(element)
      ////console.log("element", element)
      if(element.name == 'boolTable1_9'){
      this.boolArray[index].prop= false;
      }else{
      this.boolArray[index].prop= true;
      }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_10':
      {
      this.tetxHeader='Tabla 4: '
      this.boolArray.forEach(element => {
      let index = this.boolArray.indexOf(element)
      ////console.log("element", element)
      if(element.name == 'boolTable1_10'){
        this.boolArray[index].prop= false;
      }else{
        this.boolArray[index].prop= true;
      }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_11':
      {
        this.boolArray.forEach(element => {
        let index = this.boolArray.indexOf(element)
        ////console.log("element", element)
        if(element.name == 'boolTable1_11'){
          this.boolArray[index].prop= false;
        }else{
          this.boolArray[index].prop= true;
        }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_12':
      {
        this.boolArray.forEach(element => {
        let index = this.boolArray.indexOf(element)
        ////console.log("element", element)
        if(element.name == 'boolTable1_12'){
          this.boolArray[index].prop= false;
        }else{
          this.boolArray[index].prop= true;
        }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_13':
        {
          this.tetxHeader='Tabla 5: '
          this.boolArray.forEach(element => {
          let index = this.boolArray.indexOf(element)
          ////console.log("element", element)
          if(element.name == 'boolTable1_13'){
            this.boolArray[index].prop= false;
          }else{
            this.boolArray[index].prop= true;
          }
        });
        //this.showTimer = action;
      }
        break;
      case 'boolTable1_14':
        {
          this.boolArray.forEach(element => {
          let index = this.boolArray.indexOf(element)
          ////console.log("element", element)
          if(element.name == 'boolTable1_14'){
            this.boolArray[index].prop= false;
          }else{
            this.boolArray[index].prop= true;
          }
        });
        //this.showTimer = action;
      }
        break;
      case 'boolTable1_15':
      {
      this.boolArray.forEach(element => {
      let index = this.boolArray.indexOf(element)
      ////console.log("element", element)
      if(element.name == 'boolTable1_15'){
      this.boolArray[index].prop= false;
      }else{
      this.boolArray[index].prop= true;
      }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_16':
      {
      this.tetxHeader='Tabla 6: '
      this.boolArray.forEach(element => {
      let index = this.boolArray.indexOf(element)
      ////console.log("element", element)
      if(element.name == 'boolTable1_16'){
        this.boolArray[index].prop= false;
      }else{
        this.boolArray[index].prop= true;
      }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_17':
      {
        this.boolArray.forEach(element => {
        let index = this.boolArray.indexOf(element)
        ////console.log("element", element)
        if(element.name == 'boolTable1_17'){
          this.boolArray[index].prop= false;
        }else{
          this.boolArray[index].prop= true;
        }
      });
      //this.showTimer = action;
      }
        break;
      case 'boolTable1_18':
      {
        this.boolArray.forEach(element => {
        let index = this.boolArray.indexOf(element)
        ////console.log("element", element)
        if(element.name == 'boolTable1_18'){
          this.boolArray[index].prop= false;
        }else{
          this.boolArray[index].prop= true;
        }
      });
      //this.showTimer = action;
      }
        break;
        
        default:
        break;
    }
  }
  

}
