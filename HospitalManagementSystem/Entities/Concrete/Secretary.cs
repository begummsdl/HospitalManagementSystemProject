﻿using HospitalManagementSystem.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities.Concrete
{
    public class Secretary:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
