using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using rph.Models;
using Newtonsoft.Json;

namespace rph.ApiControllers
{
    public class SubjectController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var subjects = new List<Subject>() { 
                new Subject(){ SubjectID = Guid.NewGuid().ToString(), Name = "English", Code = "KBSR ENGLISH"},
                new Subject(){ SubjectID = Guid.NewGuid().ToString(), Name = "Melayu", Code = "KBSR MELAYU"}
            };

            //var subjectSerialized = JsonConvert.SerializeObject(subjects);

            return Ok(subjects);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}