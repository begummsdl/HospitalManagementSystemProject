using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess.Abstract
{
    public interface IAppointmentDal:IEntityRepository<Appointment>
    {
        List<AppointmentDetailsDto> GetAppointmentDetails();
        List<AppointmentDetailsForExaminationDto> GetAppointmentDetailsByDoctorId(int DoctorId);
    }
}
