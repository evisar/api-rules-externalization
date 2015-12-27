using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IDomain<T>
        where T: class
    {
        //command
        bool Save(T item);
        
        //event
        void Raise(IEvent<T> @event);

        //rules
        IEnumerable<IRule<T>> Rules { get; }
    }
}
