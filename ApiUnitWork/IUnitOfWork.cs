using ApiRepositories.system_management;
using ApiRepositories.testH;

namespace ApiUnitWork
{
    using ApiRepositories;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IUnitOfWork
    {
        ITeachersRepository ITeachers { get; }
        IStudentsRepository IStudents { get; }
        IStaffRepository IStaff { get; }
        IDepartmentsRepository IDepartments { get; }
        IStudentdepartamentRepository IStudentdepartament { get; }
        ITeacherdepartamentRepository ITeacherdepartament { get; }
        IAccesssystemRepository IAccesssystem { get; }
        IParametersRepository IParameters { get; }
        IParameterdetailsRepository IParameterdetails { get; }
        ITesthollandRepository ITestholland { get; }
        ITesthollandartisticopuedesRepository ITesthollandartisticopuedes { get; }
        ITesthollandartisticotegustariaRepository ITesthollandartisticotegustaria { get; }
        ITesthollandsocialeresRepository ITesthollandsocialeres { get; }
        ITesthollandsocialpuedesRepository ITesthollandsocialpuedes { get; }
        ITesthollandsocialtegustariaRepository ITesthollandsocialtegustaria { get; }
        ITesthollandemprendedoreresRepository ITesthollandemprendedoreres { get; }
        ITesthollandemprendedorpuedesRepository ITesthollandemprendedorpuedes { get; }
        ITesthollandemprendedortegustariaRepository ITesthollandemprendedortegustaria { get; }
        ITesthollandconvencionaleresRepository ITesthollandconvencionaleres { get; }
        ITesthollandconvencionalpuedesRepository ITesthollandconvencionalpuedes { get; }
        ITesthollandconvencionaltegustariaRepository ITesthollandconvencionaltegustaria { get; }
        ITesthollanddetailsRepository ITesthollanddetails { get; }
        ITesthollandrealistaeresRepository ITesthollandrealistaeres { get; }
        ITesthollandrealistapuedesRepository ITesthollandrealistapuedes { get; }
        ITesthollandrealistategustariaRepository ITesthollandrealistategustaria { get; }
        ITesthollandinvestigadoreresRepository ITesthollandinvestigadoreres { get; }
        ITesthollandinvestigadorpuedesRepository ITesthollandinvestigadorpuedes { get; }
        ITesthollandartisticoeresRepository ITesthollandartisticoeres { get; }
        ITesthollandinvestigadortegustariaRepository ITesthollandinvestigadortegustaria { get; }
        IStudycareersRepository IStudycareers { get; }
        IStudyinstitutionsRepository IStudyinstitutions { get; }
        IVocationsRepository IVocations { get; }
    }
}
