using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebFormInvoiceAPI.DomainObject;

namespace WebFormInvoiceAPI.Model
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext()
        {

        }

        public InvoiceContext(DbContextOptions<InvoiceContext> options)
            : base(options)
        { }

        public virtual DbSet<Consumen> Consumen { get; set; }
        public virtual DbSet<Currencys> Currencys { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<UOMS> UOMS { get; set; }
        public virtual DbSet<PurchaseOrders> PurchaseOrders { get; set; }
        public virtual DbSet<Number> Number { get; set; }
        public virtual DbSet<InvoiceHeader> InvoiceHeader { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NamaServer;Database=Database;User Id=user;Password=password;Connect Timeout=900;");
            }
        }
    }
}
