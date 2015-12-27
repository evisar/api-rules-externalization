using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain
{
    public class Sale
    {
        public int Id { get; set; }
        public string DWNumber { get; set; }
        public List<SaleItem> Items { get; set; }
    }
}
