using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Common
{
    public interface IRule<T>
        where T: class
    {
        bool Apply(string method, T item);
    }
}
