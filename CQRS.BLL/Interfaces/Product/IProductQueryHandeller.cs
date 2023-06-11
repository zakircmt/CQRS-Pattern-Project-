using CQRS.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.BLL.Interfaces.Product
{
    public interface IProductQueryHandeller
    {
        List<TblProduct> GetAllProducts();
    }
}
