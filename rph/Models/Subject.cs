using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

using rph.Interface;

namespace rph.Models
{
    [Table("Subject")]
    public class Subject : ISubject
    {
        public Subject()
        {
            ID = Guid.NewGuid().ToString();
            CreatedOn = DateTime.Now;
            ModifyOn = DateTime.Now;
        }

        [Key]
        public string ID { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [Display (Name="Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Code is required")]
        [Display(Name = "Code")]
        public string Code { get; set; }

        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifyOn { get; set; }
        public string ModifyBy { get; set; }

    }
}