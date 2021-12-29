using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversumOOP.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Costumer> Costumers { get; set; }
        public MyDbContext() : base("UniversumSQL")
        {

        }
    }
}