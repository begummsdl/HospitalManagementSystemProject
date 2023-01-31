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
    public interface ISecretaryServive
    {
        IResult Add(Secretary secretary);
        IResult Update(Secretary secretary);
        IResult Delete(int secretaryId);

        IDataResult<Secretary> GetById(int id);
        IDataResult<List<SecretayDetailsDto>> GetAllDetails();
        IResult Register(SecretaryForRegisterDto secretaryForRegisterDto, string password);
    }
}
