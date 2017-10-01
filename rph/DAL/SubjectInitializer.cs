using rph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rph.DAL
{
    public class SubjectInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SubjectContext>
    {
        protected override void Seed(SubjectContext context)
        {
            var subjects = new List<Subject>
            {
                new Subject{ Name = "ENGLISH", Code = "KBSR_ENGLISH"},
                new Subject{ Name = "MELAYU", Code = "KBSR_MELAYU"},
                new Subject{ Name = "MATHEMATICS", Code = "KBSR_MATHEMATICS"}
            };

            subjects.ForEach(x => context.Subjects.Add(x));
            context.SaveChanges();
        }
    }
}