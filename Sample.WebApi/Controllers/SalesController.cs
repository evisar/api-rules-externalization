using Domain.Common;
using Sample.Domain;
using Sample.Domain.Domains;
using Sample.WebApi.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample.WebApi
{
    public class SalesController : GenericController<Sale>
    {
        public SalesController(IDomain<Sale> domain):base(domain){}
    }
}