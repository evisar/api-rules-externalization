using Domain.Common.Rules;
using Sample.Domain;
using Sample.Domain.Rules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Sample.WebApi.Rules
{
    public class RuleFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var type = actionContext.ControllerContext.Controller.GetType();
            type = type.BaseType.GetGenericArguments().First();
            var ruleFilterType = typeof(RuleFilter<>).MakeGenericType(type);            
            dynamic ruleFilter = Activator.CreateInstance(ruleFilterType);
            var item = actionContext.ActionArguments.First().Value;
            dynamic controller = actionContext.ControllerContext.Controller;
            var domain = controller.Domain;
            ruleFilterType.GetMethod("Before").Invoke(ruleFilter, new[]{ domain, item});            
        }
    }


}