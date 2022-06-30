using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class TestModel
    {
        [Key]
        public int TestID { get; set; }

        public virtual List<Quotes> Quotes { get; set; }
    }
}
