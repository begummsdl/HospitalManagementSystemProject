using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Core.Utilities.Results;
using HospitalManagementSystem.DataAccess.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Concrete
{
    public class PatientManager : IPatientService
    {
        IPatientDal _patientDal;

        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        public IResult Add(Patient patient)
        {
            _patientDal.Add(patient);
            return new SuccessResult();
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult();
        }

        public IDataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll());
        }

        public IDataResult<Patient> GetById(int id)
        {
            return new SuccessDataResult<Patient>(_patientDal.Get(r => r.Id == id));
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient);
            return new SuccessResult();
        }
    }
}
