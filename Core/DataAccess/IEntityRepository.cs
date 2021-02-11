using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Core katmanı başka bir katmanı referans almaz core katmanı evrensel bir katmandır

    // Generic repository design pattern. Ortak kullanılacak generic type  heryere aynı kodu yazmakla ugraşmayız.
    // IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    // new(): newlenir olması gerek.
    public interface IEntityRepository<T> where T : class, IEntity, new()

    {  // GENERİC CONSTRAİNT : generic kısıtlama. class: referans type olabilir demek.burası suan ya entity olabilir yada implement alan.
        // Expression<Func<T,bool>> filter=null  filtreler yazabilmeizi saglayan syntax.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);  // Ürünleri Listele dedilk ve artık bu interface product classına bagımlı hale geldi.

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId); // ürünleri categoryId sine göre getir.
    }
}
