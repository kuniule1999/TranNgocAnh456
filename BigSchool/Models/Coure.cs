using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Coure
    {
        public int Id { get; set; }
        public ApplicationUser lecturer { get; set; }
        [Required]
        public string LecturerId
    }
}