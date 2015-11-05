using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApiServer.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }     
    }

    public class CrmDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
