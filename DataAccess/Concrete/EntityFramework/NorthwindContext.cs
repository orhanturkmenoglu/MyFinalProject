using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace DataAccess.Concrete.EntityFramework
{
    // Context  : Db tabloları ile proje classlarını baglamak.
    // onconfiguring : bizim hangi veritabanı ile ilişkilendirecegimiz yer.
    //  optionsBuilder.UseSqlServer(); sql server kullanacagız ve baglantı türünü girmemiz yeterli
    //  Trusted_Connection=true ; kullanıcı adı ve şifre girmeden veritabanına baglanmamızı saglar
    // Database =Northwind; veritabanımızdaki northwind tablosuyla çalışıyoruz.
    // Dbset<> : hangi nesnem hangi nesneye karşılık geldihini belirtmemizi saglar
    class NorthwindContext  : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-UCTAT7I\mssqlserver2022;Database =Northwind; Trusted_Connection=true");
           
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
