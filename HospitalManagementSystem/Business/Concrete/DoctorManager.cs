using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Core.Utilities.Results;
using HospitalManagementSystem.Core.Utilities.Security.Hashing;
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
    public class DoctorManager : IDoctorService
    {
        IDoctorDal _doctorDal;
        IUserDal _userDal;

        public DoctorManager(IDoctorDal doctorDal, IUserDal userDal)
        {
            _doctorDal = doctorDal;
            _userDal = userDal;
        }

        public IResult Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
            return new SuccessResult();
        }

        public IResult Delete(int doctorId)
        {
            Doctor doctor = this.GetById(doctorId).Data;
            _doctorDal.Delete(doctor);
            return new SuccessResult();
        }

        public IDataResult<List<Doctor>> GetAll()
        {
            return new SuccessDataResult<List<Doctor>>(_doctorDal.GetAll());
        }

        public IDataResult<List<DoctorDetailsDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<DoctorDetailsDto>>(_doctorDal.GetDoctorDetails());
        }

        public IDataResult<Doctor> GetById(int Id)
        {
            return new SuccessDataResult<Doctor>(_doctorDal.Get(d => d.Id == Id));
        }

        public IDataResult<Doctor> GetByUserId(int userId)
        {
            return new SuccessDataResult<Doctor>(_doctorDal.Get(d => d.UserId == userId));
        }

        public IResult Register(DoctorForRegisterDto doctorForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                FirstName = doctorForRegisterDto.FirstName,
                LastName = doctorForRegisterDto.LastName,
                Email = doctorForRegisterDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = doctorForRegisterDto.Status
            };
            _userDal.Add(user);

            var doctor = new Doctor
            {
                UserId = user.Id,
                Phone = doctorForRegisterDto.Phone,
                Address = doctorForRegisterDto.Address,
                Gender = doctorForRegisterDto.Gender,
                Speciality = doctorForRegisterDto.Speciality
            };
            this.Add(doctor);

            return new SuccessResult();
        }

        public IResult Update(Doctor doctor)
        {
            _doctorDal.Update(doctor);
            return new SuccessResult();
        }

    }
}
