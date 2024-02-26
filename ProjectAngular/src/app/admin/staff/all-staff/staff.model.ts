import { formatDate } from '@angular/common';
export class Staff {
  id: number;
  img: string;
  name: string;
  email: string;
  date: string;  
  mobile: string;
  designation: string;
  constructor(staff) {
    {
      this.id = staff.id || 0;
      this.img = staff.avatar || 'assets/images/user/user1.jpg';
      this.name = staff.name || '';
      this.designation = staff.designation || '';
      this.email = staff.email || '';
      this.date = formatDate(new Date(), 'yyyy-MM-dd', 'en') || '';      
      this.mobile = staff.mobile || '';
    }
  }
  
}
export class  accessSystem{
  id : number;
  idUser : number;
  userType : number;
  userName : string;
  password : string;
}
