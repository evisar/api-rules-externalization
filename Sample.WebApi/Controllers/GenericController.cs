using Domain.Common;
using Newtonsoft.Json;
using Sample.Domain;
using Sample.WebApi.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample.WebApi
{
    public class GenericController<T> : ApiController
        where T: class
    {

        internal IDomain<T> Domain { get; private set; }

        public GenericController(IDomain<T> domain)
        {
            this.Domain = domain;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        [RuleFilter]
        // POST api/<controller>
        public void Post([FromBody]T value)
        {
            this.Domain.Save(value);            
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]T value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}