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
    public class SecretaryDal : EntityRepositoryBase<Secretary, HMSContext>, ISecretaryDal
    {
        public List<SecretayDetailsDto> GetSecretaryDetails()
        {
            using (HMSContext context = new HMSContext())
            {
                var result = from secretary in context.Secretaries
                             join user in context.Users on secretary.UserId equals user.Id
                             select new SecretayDetailsDto
                             {
                                 Id = secretary.Id,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 Email = user.Email,
                                 Status = user.Status
                             };
                return result.ToList();
            }
        }
    }
}
