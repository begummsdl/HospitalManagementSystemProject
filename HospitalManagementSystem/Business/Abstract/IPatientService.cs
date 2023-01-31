using HospitalManagementSystem.Core.Utilities.Results;
using HospitalManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Abstract
{
    public interface IPatientService
    {
        IResult Add(Patient patient);
        IResult Update(Patient patient);
        IResult Delete(Patient patient);

        IDataResult<List<Patient>> GetAll();
        IDataResult<Patient> GetById(int id);
    }
}
