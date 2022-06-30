using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class ViewTest
    {
        [Key]
        public int MyProperty { get; set; }
        public string address { get; set; }
    }
}
