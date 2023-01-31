using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Core.Utilities.Results;
using HospitalManagementSystem.DataAccess.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public IResult Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
            return new SuccessResult();
        }

        public IResult Delete(Appointment appointment)
        {
            _appointmentDal.Delete(appointment);
            return new SuccessResult();
        }

        public IDataResult<List<Appointment>> GetAll()
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll());
        }

        public IDataResult<List<AppointmentDetailsDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<AppointmentDetailsDto>>(_appointmentDal.GetAppointmentDetails());
        }

        public IDataResult<List<AppointmentDetailsForExaminationDto>> GetAppointmentDetailsByDoctorId(int doctorId)
        {
            return new SuccessDataResult<List<AppointmentDetailsForExaminationDto>>(_appointmentDal.GetAppointmentDetailsByDoctorId(doctorId));
        }

        public IDataResult<List<Appointment>> GetByDoctorId(int id)
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(r => r.DoctorId == id));
        }

        public IDataResult<Appointment> GetById(int id)
        {
            return new SuccessDataResult<Appointment>(_appointmentDal.Get(r => r.Id == id));
        }

        public IDataResult<List<Appointment>> GetByPatientId(int id)
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll(r => r.PatientId == id));
        }

        public IResult Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
            return new SuccessResult();
        }
    }
}
