using Rules.Common;
using Sample.Domain;
using Sample.Domain.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Sample.WebApi.Rules
{
    public class RuleFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            new SaleDWNumberUniqueRule().Apply(actionContext.ActionDescriptor.ActionName, (Sale)actionContext.ActionArguments.First().Value);
        }
    }
}