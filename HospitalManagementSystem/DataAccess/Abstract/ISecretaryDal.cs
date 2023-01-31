using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess.Abstract
{
    public interface ISecretaryDal:IEntityRepository<Secretary>
    {
        List<SecretayDetailsDto> GetSecretaryDetails();
    }
}
