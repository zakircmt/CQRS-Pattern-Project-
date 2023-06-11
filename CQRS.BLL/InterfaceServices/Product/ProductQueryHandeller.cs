using CQRS.BLL.Interfaces.Product;
using CQRS.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.BLL.InterfaceServices.Product
{
    public class ProductQueryHandeller : IProductQueryHandeller
    {
        private CQRSContext db;
        public ProductQueryHandeller(CQRSContext _db)
        {
            db = _db;
        }
        public List<TblProduct> GetAllProducts()
        {
            var listOfProduct = db.Products.ToList();
            return listOfProduct;
        }
    }
}
