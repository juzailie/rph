using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using rph.Models;
using Newtonsoft.Json;
using rph.DAL;

namespace rph.ApiControllers
{
    public class SubjectController : ApiController
    {

        private SubjectContext db = new SubjectContext();

        // GET api/<controller>
        public IHttpActionResult Get()
        {
            var sb = db.Subjects.ToList();

            return Ok(sb);
        }

        [HttpPost]
        public IHttpActionResult GetData([FromBody] DataTableAjaxPostModel model)
        {
            var sb = db.Subjects.ToList();

            var response = new
            {
                // this is what datatables wants sending back
                draw = model.draw,
                recordsTotal = sb.Count,
                recordsFiltered = sb.Count,
                data = sb
            };

            return Ok(response);
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