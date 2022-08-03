using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    // EfCoreGenericRepository<TEntity,TContext>: Bu iki tipte  bana bir şey ver
    //IRepository<TEntity>: Hangi tabloyu verirsem onun tablosu olucak
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                /*var data= context.Set<TEntity>().Add(entity).Entity;*///eklediğimde verinin veri tabanındakı referansını geri döndürür.
                context.Set<TEntity>().Add(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
              await  context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? //filtre nul ise
                await context.Set<TEntity>().ToListAsync()  //YANİ FİLTRELİ DEGİLSE HEPSİNİ GEİTR
                : await context.Set<TEntity>().Where(filter).ToListAsync();//FİLTERE VARSA FİLTRELEYİP VER

            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);//bu filtreyi metotda uygula
            }
        }
       
        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Update(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
