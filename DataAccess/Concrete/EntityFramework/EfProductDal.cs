using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //  IDisposaple pattern implementation c# : (using)  içerisine yazdıgımız nesneler kullanıldıktan sonra anında bellekten silinir
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);  // entry (): gelen degeri eşleştir referansı yakala
                addedEntity.State = EntityState.Added;    // state : durumu ne yapayım EntityState.Added : eklememizi saglar.
                context.SaveChanges(); // ekle kaydet.

            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);  // entry (): gelen degeri eşleştir referansı yakala
                deletedEntity.State = EntityState.Deleted;    // state : durumu ne yapayım EntityState.Added : eklememizi saglar.
                context.SaveChanges(); // sil. kaydet.

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                // product dönderecek bir ürün hakkında detaylı getirmemizi saglar.
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                // filter == null ? ise filtreyi getir. null ise 
                // context.Set<Product>().ToList() : product ile çalış tümünü getir
                // : context.Set<Product>().Where(p =>p.ProductId); degilse filtreyi getir.
                return filter == null ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
                    
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);  // entry (): gelen degeri eşleştir referansı yakala
                updatedEntity.State = EntityState.Modified;    // state : durumu ne yapayım EntityState.Added : eklememizi saglar.
                context.SaveChanges(); // güncelle. kaydet.

            }
        }
    }
}
