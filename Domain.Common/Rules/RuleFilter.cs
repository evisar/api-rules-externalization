using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Common.Rules
{
    public class RuleFilter<T>
        where T : class
    {
        public virtual void Before(IDomain<T> domain, T item)
        {
            foreach (var rule in domain.Rules)
            {
                var result = rule.Apply(item);

                if (!result)
                {
                    throw new InvalidOperationException("Rule " + rule.GetType().Name + " failed.");
                }
            }

        }
    }
}