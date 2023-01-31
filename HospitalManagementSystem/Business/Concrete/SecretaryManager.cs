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
    public class SecretaryManager : ISecretaryServive
    {
        ISecretaryDal _secretaryDal;
        IUserDal _userDal;

        public SecretaryManager(ISecretaryDal secretaryDal, IUserDal userDal)
        {
            _secretaryDal = secretaryDal;
            _userDal = userDal;
        }

        public IResult Add(Secretary secretary)
        {
            _secretaryDal.Add(secretary);
            return new SuccessResult();
        }

        public IResult Delete(int secretaryId)
        {
            Secretary secretary = _secretaryDal.Get(s => s.Id == secretaryId);
            _secretaryDal.Delete(secretary);
            return new SuccessResult();
        }

        public IDataResult<List<SecretayDetailsDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<SecretayDetailsDto>>(_secretaryDal.GetSecretaryDetails());
        }

        public IResult Update(Secretary secretary)
        {
            _secretaryDal.Update(secretary);
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
            _userDal.Add(user);

            var secretary = new Secretary
            {
                UserId = user.Id
            };
            this.Add(secretary);

            return new SuccessResult();
        }

        public IDataResult<Secretary> GetById(int id)
        {
            return new SuccessDataResult<Secretary>(_secretaryDal.Get(s => s.Id == id));
        }
    }
}
