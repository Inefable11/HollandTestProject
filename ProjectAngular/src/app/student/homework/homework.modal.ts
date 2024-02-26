export class Homework {
  id: string;
  class: string;
  section: string;
  subject: string;
  homeworkDate: string;
  submissionDate: string;
  evalutionDate: string;
  status: string;
}
export interface studyInstitutions {
  id: number;
  name: string;
  studyCareers: string;
  description: string;
  details: string;
  img: string;
  isActive: boolean | null;
  url: string;
}
export interface studyCareers {
  id: number;
  name: string;
  jobProfile: string;
  workField: string;
  img: string;
  isActive: boolean | null;
}