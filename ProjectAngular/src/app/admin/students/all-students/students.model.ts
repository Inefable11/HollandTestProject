import { formatDate } from '@angular/common';
export class Students {
  id: number;
  img: string;
  name: string;
  email: string;
  dateJoin: string;
  gender: string;
  mobile: string;
  department: number;
  address:string;
  rollNo: string;
  bloodGroup: string;
  dateBirth: string;
  studentCode: string;
  parentsName : string;
  parentsPhone : string;
  constructor(students) {
    {
      this.id = students.id;// || this.getRandomID();
      this.img = students.avatar || 'assets/images/user/user1.jpg';
      this.name = students.name || '';
      this.email = students.email || '';
      this.dateJoin = formatDate(new Date(), 'yyyy-MM-dd', 'en') || '';
      this.gender = students.gender || '';
      this.mobile = students.mobile || '';
      this.department = students.department || 0;
      this.rollNo = students.rollNo || '';
      this.address = students.address || '';
      this.bloodGroup = students.bloodGroup || '';
      this.dateBirth = formatDate(new Date(), 'yyyy-MM-dd', 'en') || '';
      this.studentCode = students.bloodGroup || '';
      this.parentsName = students.bloodGroup || '';
      this.parentsPhone = students.bloodGroup || '';
    }
  }
  /*public getRandomID(): string {
    const S4 = () => {
      return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
    };
    retur*n S4() + S4();
  }*/
}
export class  accessSystem{
  id : number;
  idUser : number;
  userType : number;
  userName : string;
  password : string;
}