using Store.Core.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class SaleRepository : Repository<int, sale>
    {
        public SaleRepository(StoreDataContext context) : base(context)
        {

        }
    }
}
