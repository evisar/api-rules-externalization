using Domain.Common;
using Sample.Domain.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.Domains
{
    public class SalesDomain: IDomain<Sale>
    {
        List<Sale> _sales = new List<Sale>();
        
        public bool IsDWNUmberUnique(string dwnumber)
        {
            return _sales.All(s => s.DWNumber != dwnumber);
        }


        public bool Save(Sale item)
        {
            _sales.Add(item);
            return true;
        }


        public void Raise(IEvent<Sale> @event)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IRule<Sale>> Rules
        {
            get
            {
                yield return new SaleDWNumberUniqueRule(this);
            }
        }
    }
}
