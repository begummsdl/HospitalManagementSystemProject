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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        ISecretaryServive _secretaryServive;

        public UserManager(IUserDal userDal, ISecretaryServive secretaryServive)
        {
            _userDal = userDal;
            _secretaryServive = secretaryServive;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(int userId)
        {
            User user = _userDal.Get(u => u.Id == userId);
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IResult Register(SecretaryForRegisterDto secretaryForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                FirstName = secretaryForRegisterDto.FirstName,
                LastName = secretaryForRegisterDto.LastName,
                Email = secretaryForRegisterDto.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = secretaryForRegisterDto.Status
            };
            this.Add(user);

            var secretary = new Secretary
            {
                UserId = user.Id
            };
            _secretaryServive.Add(secretary);

            return new SuccessResult();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            User userToCheck = this.GetByEmail(userForLoginDto.Email).Data;
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>();
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>();
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }

        public IDataResult<User> GetByEmail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public string GetSatustByEmail(string email)
        {
            User user = _userDal.Get(u => u.Email == email);
            return user.Status;
        }

        public int GetIdByEmail(string email)
        {
            User user = _userDal.Get(u => u.Email == email);
            return user.Id;
        }

        public IResult UpdatePassword(int userId, string oldPassword, string newPassword)
        {
            User user = _userDal.Get(u => u.Id == userId);
            if (!HashingHelper.VerifyPasswordHash(oldPassword, user.PasswordHash, user.PasswordSalt))
            {
                return new ErrorResult();
            }

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(newPassword, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            _userDal.Update(user);
            return new SuccessResult();
        }

        public byte[] GetPassHashById(int userId)
        {
            User user = _userDal.Get(u => u.Id == userId);
            return user.PasswordHash;
        }

        public byte[] GetPassSaltById(int userId)
        {
            User user = _userDal.Get(u => u.Id == userId);
            return user.PasswordSalt;
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }
    }
}
