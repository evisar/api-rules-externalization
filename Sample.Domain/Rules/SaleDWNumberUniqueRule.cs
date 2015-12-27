using Domain.Common;
using Sample.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Rules
{
    public class SaleDWNumberUniqueRule: IRule<Sale>
    {
        readonly SalesDomain _domain;
        public SaleDWNumberUniqueRule(SalesDomain domain)
        {
            _domain = domain;
        }
        public bool Apply(Sale item)
        {
            return _domain.IsDWNUmberUnique(item.DWNumber);
        }
    }
}
