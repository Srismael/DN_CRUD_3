using Store.Core.Sale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class SaleDetailRepository : Repository<int, sale_detail>
    {
        public SaleDetailRepository(StoreDataContext context) : base(context)
        {

        }
    }
}
