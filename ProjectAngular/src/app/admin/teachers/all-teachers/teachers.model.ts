import { formatDate } from '@angular/common';
export class Teachers {
  id: number;
  img: string;
  name: string;
  email: string;
  date: Date;
  gender: string;
  mobile: string;
  department: string;
  degree: string;
  constructor(teachers) {
    {
      this.id = teachers.id;// || this.getRandomID();
      this.img = teachers.avatar || 'assets/images/user/user1.jpg';
      this.name = teachers.name || '';
      this.email = teachers.email || '';
      this.date = new Date();
      this.gender = teachers.gender || '';
      this.mobile = teachers.mobile || '';
      this.department = teachers.department || '';
      this.degree = teachers.degree || '';
    }
  }
  /*public getRandomID(): string {
    const S4 = () => {
      return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
    };
    return S4() + S4();
  }*/
}
export class parameterDetails {
  id: number;
  idParameter: number;
  code: string;
  value_1: string;
  value_2?: any;
  value_3?: any;
  sort?: any;
  isActive: boolean;
}
export class  accessSystem{
  id : number;
  idUser : number;
  userType : number;
  userName : string;
  password : string;
}