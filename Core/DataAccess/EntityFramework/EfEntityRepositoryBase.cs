using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    // Core katmanına da entity framework sql serveri bagladık.
    //  IEntityRepository<TEntity> bu interfaceden implementasyon yapması gerek IEntity operasyonlarına ulş
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        // kısıtlama yaptık bunu kullanacak sınıflar bu özellikleri vermeli.
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            // Using içerisine yazdgımız nesneler çalıştıktan sonra işi bitince biter.silinir bellekten.
            // IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); // ekleme  referansı yakaladık once
                addedEntity.State = EntityState.Added; // eklenecek nesne
                context.SaveChanges(); // degişiklikleri kaydet

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); // silme  referansı yakaladık once
                deletedEntity.State = EntityState.Deleted; // silinecek nesne
                context.SaveChanges(); // degişiklikleri kaydet

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); // filtreledigimiz tabloyu getir.
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                // tüm tabloyu null ise getir degilse
                // filtereleme yaptgımız tabloyu getir.parametre olarak 
                // gonderecegımız filtereyi yazar. filter yerine.
                return filter == null ? context.Set<TEntity>().ToList() :
                   context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public List<TEntity> GetAllByCategory(int categoryId)
        {
            using (TContext context = new TContext())
            {
                return context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); // güncellenecek  referansı yakaladık once
                updatedEntity.State = EntityState.Modified; // güncellenecek nesne
                context.SaveChanges(); // degişiklikleri kaydet

            }
        }
    }
}
