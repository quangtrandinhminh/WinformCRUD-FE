using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public object this[int eRowIndex]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
