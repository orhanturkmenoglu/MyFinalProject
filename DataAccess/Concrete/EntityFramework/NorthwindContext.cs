using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // Context : Db tablolari ile proje classlarını baglamak ilişkilendirmek için kullanılır
    public class NorthwindContext:DbContext // DbContext Paket ile gelen Interfacedir.
    {
        // Bu method bızım hangı veritabanı ile ilişkilendirecegimiz methodtur. override yazarak ulaştık bu methoda.
        // Trusted_Connection=true :kullanıcı adı şifre gerekmeden girmek için yazdık
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-FU80MA6U\SQLEXPRESS;Database=Northwind;Trusted_Connection=true"); // hangi veritabanına baglanıcagımızı yazacagız
        }

        // burda hangi classımız hangı tabloya karsılık geldinigini belirtmemiz lazım.
        public DbSet<Product> Products{ get; set; }  
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
