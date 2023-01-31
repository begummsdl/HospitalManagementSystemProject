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
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(int userId);
        IResult UpdatePassword(int userId,string oldPassword,string newPassword);

        IResult Register(SecretaryForRegisterDto secretaryForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<User> GetByEmail(string email);
        IDataResult<User> GetById(int id);

        string GetSatustByEmail(string email);
        int GetIdByEmail(string email);
        byte[] GetPassHashById(int userId);
        byte[] GetPassSaltById(int userId);
    }
}
