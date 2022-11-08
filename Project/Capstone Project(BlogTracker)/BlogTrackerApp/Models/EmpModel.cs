using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogTrackerApp.Models
{
    public class EmpModel
    {
        [Required()]
        [Key]
        [DataType(DataType.Password)]
        public int Passcode { get; set; }
        public string EmailID { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateOfJoining { get; set; }
    }
}