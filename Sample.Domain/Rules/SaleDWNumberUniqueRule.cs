using Rules.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Rules
{
    public class SaleDWNumberUniqueRule: IRule<Sale>
    {
        public bool Apply(string method, Sale item)
        {
            throw new NotImplementedException();
        }
    }
}
