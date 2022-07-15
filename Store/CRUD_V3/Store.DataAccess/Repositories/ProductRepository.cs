using Store.Core.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class ProductRepository : Repository<int, product>
    {
        public ProductRepository(StoreDataContext context) : base(context)
        {

        }
    }
}
