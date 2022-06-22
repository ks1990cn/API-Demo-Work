using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Quotes
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

        public int Phone { get; set; }
        public string address { get; set; }
    }
}
