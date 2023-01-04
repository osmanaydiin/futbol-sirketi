using takim1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace takim1.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context c = new Context();

        public void TAdd(T t1)
        {
            c.Set<T>().Add(t1);
            c.SaveChanges();
        }
        public void TRemove(T t1)
        {
            c.Set<T>().Remove(t1);
            c.SaveChanges();
        }
        public void TUpdate(T t1)
        {
            c.Set<T>().Update(t1);
            c.SaveChanges();
        }
        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public T TGet(int id)
        {
            return c.Set<T>().Find(id);
        }
        public List<T> TList(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }
        public List<T> List(Expression<Func<T, bool>> predicate)
        {
            return c.Set<T>().Where(predicate).ToList();
        }
    }
}