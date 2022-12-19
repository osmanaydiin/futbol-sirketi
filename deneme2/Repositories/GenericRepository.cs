using deneme2.Models;
using Microsoft.EntityFrameworkCore;

namespace deneme2.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCoreKitap c = new DbCoreKitap();

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
        public void TGet(int id)
        {
            c.Set<T>().Find(id);
        }
        public List<T> TList(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }
    }
}
