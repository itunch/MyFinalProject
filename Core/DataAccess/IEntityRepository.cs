using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint : kısıtlar 
    //class referas tip
    //IEntity IEntity olabilir veya IEntity 
    //new(): newlenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new() //generic, referans tip ve sadece IEntity dahil olanları eklemesi için
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);      
       
    }
}
