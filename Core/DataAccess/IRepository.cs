using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IRepository<T>where T : class,IEntity,new()
    {
        //IEnumerable:IEnumerable, generic olamayan bir koleksiyon üzerinde iterasyon(liste içerisinde dönmemizi) yapmamızı sağlar.
        //Aslında daha çok memory(bellek) üzerinde muhafıza edilen veriler üzerinden gerekli sorgulama işlemleri yapar.
        //. Net Framework altında System.Collection isim uzayından türemektedir
        Task< IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>> filter=null);
        Task< T> GetAsync(Expression<Func<T, bool>> filter = null);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
