using HospitalManagementSystem.DataAccess.Abstract;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess.Concrete
{
    public class DoctorDal : EntityRepositoryBase<Doctor, HMSContext>, IDoctorDal
    {
        public List<DoctorDetailsDto> GetDoctorDetails()
        {
            using (HMSContext context = new HMSContext())
            {
                var result = from doctor in context.Doctors
                             join user in context.Users on doctor.UserId equals user.Id
                             select new DoctorDetailsDto
                             {
                                 Id = doctor.Id,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Address = doctor.Address,
                                 Email = user.Email,
                                 Gender = doctor.Gender,
                                 Phone = doctor.Phone,
                                 Status = user.Status,
                                 Speciality = doctor.Speciality
                             };
                return result.ToList();
            }
        }   
    }
}
