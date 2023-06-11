using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Database
{
    public class TblProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
    }
}
