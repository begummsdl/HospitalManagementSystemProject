using HospitalManagementSystem.Core.Utilities.Results;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Abstract
{
    public interface IDoctorService
    {
        IResult Add(Doctor doctor);
        IResult Delete(int doctorId);
        IResult Update(Doctor doctor);

        IResult Register(DoctorForRegisterDto doctorForRegisterDto, string password);
        IDataResult<List<DoctorDetailsDto>> GetAllDetails();
        IDataResult<List<Doctor>> GetAll();
        IDataResult<Doctor> GetById(int Id);
        IDataResult<Doctor> GetByUserId(int userId);
    }
}
