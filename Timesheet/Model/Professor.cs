using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheet.Model
{
    public class Professor
    {
        public string ProfessorId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
