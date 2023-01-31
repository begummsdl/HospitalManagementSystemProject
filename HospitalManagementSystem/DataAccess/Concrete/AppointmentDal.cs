using HospitalManagementSystem.DataAccess.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess.Concrete
{
    public class AppointmentDal : EntityRepositoryBase<Appointment, HMSContext>, IAppointmentDal
    {
        public List<AppointmentDetailsDto> GetAppointmentDetails()
        {
            using (HMSContext context = new HMSContext())
            {
                var result = from appointment in context.Appointments
                             join doctor in context.Doctors on appointment.DoctorId equals doctor.Id
                             join user in context.Users on doctor.UserId equals user.Id
                             join patient in context.Patients on appointment.PatientId equals patient.Id
                             select new AppointmentDetailsDto
                             {
                                 Id = appointment.Id,
                                 PatientFirstName = patient.FirstName,
                                 PatientLastName = patient.LastName,
                                 IdentityNumber = patient.IdentityNumber,
                                 DoctorFirstName = user.FirstName,
                                 DoctorLastName = user.LastName,
                                 DoctorSpeciality = doctor.Speciality,
                                 AppointmentDate = appointment.Date,
                                 AppointmentTime = appointment.Time
                             };
                return result.ToList();
            }
        }

        public List<AppointmentDetailsForExaminationDto> GetAppointmentDetailsByDoctorId(int doctorId)
        {
            using (HMSContext context = new HMSContext())
            {
                var result = from appointment in context.Appointments
                             join doctor in context.Doctors on appointment.DoctorId equals doctor.Id
                             join user in context.Users on doctor.UserId equals user.Id
                             join patient in context.Patients on appointment.PatientId equals patient.Id
                             where appointment.DoctorId == doctorId
                             select new AppointmentDetailsForExaminationDto
                             {
                                 Id = appointment.Id,
                                 PatientFirstName = patient.FirstName,
                                 PatientLastName = patient.LastName,
                                 IdentityNumber = patient.IdentityNumber,
                                 DoctorFirstName = user.FirstName,
                                 DoctorLastName = user.LastName,
                                 DoctorSpeciality = doctor.Speciality,
                                 AppointmentDate = appointment.Date,
                                 AppointmentTime = appointment.Time,
                                 patientDescription = patient.Description
                             };
                return result.ToList();
            }
        }
    }
}
