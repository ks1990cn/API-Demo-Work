﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int MyProperty { get; set; }
    }
}
