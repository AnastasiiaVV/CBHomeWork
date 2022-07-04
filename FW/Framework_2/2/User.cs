using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace _2
{
	class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        
        public int OfficeId { get; set; }
        public Office Office { get; set; }
    }
}
