using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Database
{
    public class CQRSContext : DbContext
    {
        public CQRSContext()
        {
            
        }
        public CQRSContext(DbContextOptions<CQRSContext>options) : base(options)
        {

        }
        public DbSet<TblProduct> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-PDFHUCG;Database=CQRS;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
