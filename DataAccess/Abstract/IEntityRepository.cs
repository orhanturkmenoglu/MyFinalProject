using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // generic reposityor disagn pattern 
    // Expression<Func<T,bool>> filter =null  ? expression yapısı linq ile filterleme yapmamızı saglar :( filter =null  filtre vermesede olur dedik.)
    // Expression<Func<T, bool>> filter       ? tek bir datanın detaylarına gitmemizi saglar

    // Generic constraint : generic kısıtlama vermek.
    // where T :
    // class : referans tip olabilir demek.
    // IEntity: t ya IEntity olmalı ya da IEntityden implemente eden  nesne olabilir..
    // new (): newlenebilir olmalıdır.IEntity newlenemiyecegi için sadece IEntity implement alan nesnelere koyabiliriz.
    public interface IEntityRepository <T>  where T:class,IEntity,new ()
    {
        // Crud operasyonlar yer alır 
        List<T> GetAll(Expression<Func<T,bool>> filter =null); // filtre vermezsek tüm datayı döner.
        T Get(Expression<Func<T, bool>> filter);   // filter vermek zorunlu.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        
      
    }
}
