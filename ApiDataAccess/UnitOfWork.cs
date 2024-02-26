using ApiRepositories;
using ApiUnitWork;
using System;
using System.Collections.Generic;
using System.Text;
using ApiDataAccess.system_management;
using ApiDataAccess.testH;
using ApiRepositories.system_management;
using ApiRepositories.testH;


namespace ApiDataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
      public ITeachersRepository ITeachers { get; }
      public IStudentsRepository IStudents { get; }
      public IStaffRepository IStaff { get; }
      public IDepartmentsRepository IDepartments { get; }
      public IStudentdepartamentRepository IStudentdepartament { get; }
      public ITeacherdepartamentRepository ITeacherdepartament { get; }
      public IAccesssystemRepository IAccesssystem { get; }
      public IParametersRepository IParameters { get; }
      public IParameterdetailsRepository IParameterdetails { get; }
      public ITesthollandRepository ITestholland { get; }
      public ITesthollandartisticopuedesRepository ITesthollandartisticopuedes { get; }
      public ITesthollandartisticotegustariaRepository ITesthollandartisticotegustaria { get; }
      public ITesthollandsocialeresRepository ITesthollandsocialeres { get; }
      public ITesthollandsocialpuedesRepository ITesthollandsocialpuedes { get; }
      public ITesthollandsocialtegustariaRepository ITesthollandsocialtegustaria { get; }
      public ITesthollandemprendedoreresRepository ITesthollandemprendedoreres { get; }
      public ITesthollandemprendedorpuedesRepository ITesthollandemprendedorpuedes { get; }
      public ITesthollandemprendedortegustariaRepository ITesthollandemprendedortegustaria { get; }
      public ITesthollandconvencionaleresRepository ITesthollandconvencionaleres { get; }
      public ITesthollandconvencionalpuedesRepository ITesthollandconvencionalpuedes { get; }
      public ITesthollandconvencionaltegustariaRepository ITesthollandconvencionaltegustaria { get; }
      public ITesthollanddetailsRepository ITesthollanddetails { get; }
      public ITesthollandrealistaeresRepository ITesthollandrealistaeres { get; }
      public ITesthollandrealistapuedesRepository ITesthollandrealistapuedes { get; }
      public ITesthollandrealistategustariaRepository ITesthollandrealistategustaria { get; }
      public ITesthollandinvestigadoreresRepository ITesthollandinvestigadoreres { get; }
      public ITesthollandinvestigadorpuedesRepository ITesthollandinvestigadorpuedes { get; }
      public ITesthollandartisticoeresRepository ITesthollandartisticoeres { get; }
      public ITesthollandinvestigadortegustariaRepository ITesthollandinvestigadortegustaria { get; }
      public IStudycareersRepository IStudycareers { get; }
      public IStudyinstitutionsRepository IStudyinstitutions { get; }
      public IVocationsRepository IVocations { get; }


      public UnitOfWork(string connectionString)
        {
           ITeachers = new teachersRepository(connectionString);
           IStudents = new studentsRepository(connectionString);
           IStaff = new staffRepository(connectionString);
           IDepartments = new departmentsRepository(connectionString);
           IStudentdepartament = new studentDepartamentRepository(connectionString);
           ITeacherdepartament = new teacherDepartamentRepository(connectionString);
           IAccesssystem = new accessSystemRepository(connectionString);
           IParameters = new parametersRepository(connectionString);
           IParameterdetails = new parameterDetailsRepository(connectionString);
           ITestholland = new testHollandRepository(connectionString);
           ITesthollandartisticopuedes = new testHollandArtisticoPuedesRepository(connectionString);
           ITesthollandartisticotegustaria = new testHollandArtisticoTeGustariaRepository(connectionString);
           ITesthollandsocialeres = new testHollandSocialEresRepository(connectionString);
           ITesthollandsocialpuedes = new testHollandSocialPuedesRepository(connectionString);
           ITesthollandsocialtegustaria = new testHollandSocialTeGustariaRepository(connectionString);
           ITesthollandemprendedoreres = new testHollandEmprendedorEresRepository(connectionString);
           ITesthollandemprendedorpuedes = new testHollandEmprendedorPuedesRepository(connectionString);
           ITesthollandemprendedortegustaria = new testHollandEmprendedorTeGustariaRepository(connectionString);
           ITesthollandconvencionaleres = new testHollandConvencionalEresRepository(connectionString);
           ITesthollandconvencionalpuedes = new testHollandConvencionalPuedesRepository(connectionString);
           ITesthollandconvencionaltegustaria = new testHollandConvencionalTeGustariaRepository(connectionString);
           ITesthollanddetails = new testHollandDetailsRepository(connectionString);
           ITesthollandrealistaeres = new testHollandRealistaEresRepository(connectionString);
           ITesthollandrealistapuedes = new testHollandRealistaPuedesRepository(connectionString);
           ITesthollandrealistategustaria = new testHollandRealistaTeGustariaRepository(connectionString);
           ITesthollandinvestigadoreres = new testHollandInvestigadorEresRepository(connectionString);
           ITesthollandinvestigadorpuedes = new testHollandInvestigadorPuedesRepository(connectionString);
           ITesthollandartisticoeres = new testHollandArtisticoEresRepository(connectionString);
           ITesthollandinvestigadortegustaria = new testHollandInvestigadorTeGustariaRepository(connectionString);
           IStudycareers = new studyCareersRepository(connectionString);
           IStudyinstitutions = new studyInstitutionsRepository(connectionString);
           IVocations = new vocationsRepository(connectionString);
        }

        
    }
}








