using HospitalManagementSystem.DataAccess.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess.Concrete
{
    public class PatientDal:EntityRepositoryBase<Patient,HMSContext>,IPatientDal
    {
    }
}
