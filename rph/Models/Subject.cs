using rph.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rph.Models
{
    public class Subject : ISubject
    {
        public string SubjectID { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifyOn { get; set; }
        public string ModifyBy { get; set; }

    }
}