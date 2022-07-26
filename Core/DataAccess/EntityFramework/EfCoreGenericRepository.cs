using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfCoreGenericRepository<TEntity,TContext>:IRepository<TEntity>where TEntity : class where TContext :DbContext, new() 
    {
        public void Add(TEntity entity)
        {
           using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
          using(var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        //public List<TEntity> GetAll()
        //{
        //    using( var context = new TContext())
        //    {
        //      return  context.Set<TEntity>().ToList();
        //    }
        //}

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter==null ? //filtre nul ise
                    context.Set<TEntity>().ToList()  //YANİ FİLTRELİ DEGİLSE HEPSİNİ GEİTR
                    : context.Set<TEntity>().Where(filter).ToList();//FİLTERE VARSA FİLTRELEYİP VER

            }
        }

        //public TEntity GetById(int id)
        //{
        //   using(var context = new TContext())
        //    {
        //     return context.Set<TEntity>().Find(id);
        //    }
        //}

        public TEntity GetById(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);//bu filtreyi metotda uygula
            }
        }

        public void Update(TEntity entity)
        {
         using (var context = new TContext())
         {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
         }
        }
    }
}
