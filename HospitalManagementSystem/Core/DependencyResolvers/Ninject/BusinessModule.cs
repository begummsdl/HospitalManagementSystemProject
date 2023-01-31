using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Business.Concrete;
using HospitalManagementSystem.DataAccess.Abstract;
using HospitalManagementSystem.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Core.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAppointmentService>().To<AppointmentManager>().InSingletonScope();
            Bind<IAppointmentDal>().To<AppointmentDal>().InSingletonScope();

            Bind<IDoctorService>().To<DoctorManager>().InSingletonScope();
            Bind<IDoctorDal>().To<DoctorDal>().InSingletonScope();

            Bind<IPatientService>().To<PatientManager>().InSingletonScope();
            Bind<IPatientDal>().To<PatientDal>().InSingletonScope();

            Bind<ISecretaryServive>().To<SecretaryManager>().InSingletonScope();
            Bind<ISecretaryDal>().To<SecretaryDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<UserDal>().InSingletonScope();
        }
    }
}
