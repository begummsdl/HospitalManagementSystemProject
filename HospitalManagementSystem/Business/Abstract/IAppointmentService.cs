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
    public interface IAppointmentService
    {
        IResult Add(Appointment appointment);
        IResult Update(Appointment appointment);
        IResult Delete(Appointment appointment);

        IDataResult<List<Appointment>> GetAll();
        IDataResult<Appointment> GetById(int id);
        IDataResult<List<Appointment>> GetByDoctorId(int id);
        IDataResult<List<Appointment>> GetByPatientId(int id);
        IDataResult<List<AppointmentDetailsDto>> GetAllDetails();
        IDataResult<List<AppointmentDetailsForExaminationDto>> GetAppointmentDetailsByDoctorId(int doctorId);
    }
}
