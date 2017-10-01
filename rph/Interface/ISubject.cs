using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rph.Interface
{
    interface ISubject
    {
        string ID { get; set; }

        string Name { get; set; }

        string Code { get; set; }

        DateTime CreatedOn { get; set; }
        string CreatedBy { get; set; }
        DateTime ModifyOn { get; set; }
        string ModifyBy { get; set; }

    }
}
