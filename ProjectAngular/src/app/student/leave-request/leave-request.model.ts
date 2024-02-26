export class LeaveRequest {
  id: number;
  sName: string;
  className: string;
  dateStart: string;
  timeWork: string;
  status: string;
  idStudent:number;
  constructor(lectures) {
    {
      this.id = lectures.id || this.getRandomID();
      this.sName = lectures.dName || '';
      this.className = lectures.className || '';
      this.dateStart = lectures.dateStart || '';
      this.timeWork = lectures.timeWork || '';
      this.status = lectures.status || '';
      this.idStudent = lectures.idStudent || '';
    }
  }
  public getRandomID(): string {
    const S4 = () => {
      return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
    };
    return S4() + S4();
  }
}
