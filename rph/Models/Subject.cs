using rph.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rph.Models
{
    public class Subject : ISubject
    {
        public string subjectID { get; set; }

        public string name { get; set; }

    }
}