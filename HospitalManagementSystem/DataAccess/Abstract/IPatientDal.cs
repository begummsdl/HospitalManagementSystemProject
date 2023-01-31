﻿using HospitalManagementSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DataAccess.Abstract
{
    public interface IPatientDal:IEntityRepository<Patient>
    {
    }
}
