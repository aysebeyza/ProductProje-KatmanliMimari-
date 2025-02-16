using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProductProjeData.Abstract;
using ProductProjeData.Concreat;

namespace ProductProjeData.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class

    {
        Context db = new Context();
        DbSet<T> _object; // _object veri tabanı tablosunu temsil ediyor


        public GenericRepository()//ctor tab tab yaparak oluşturuyoruz
        {
            _object = db.Set<T>(); //db den gelen değeri object e aktarmak için kullanıyoruz
        }
         
       
        public void Delete(T entity)
        {
      //Entity Framework kullanarak bir nesneyi (entity) veritabanından silmek için yazılmıştır
      var sil = db.Entry(entity); // entity nesnesinin veritb.daki durumunu takip için bir EntityEntry nesnesi döndürür.
        // Yani veritabanındaki hangi durumda olduğunu(Added, Modified, Deleted, Unchanged) anlamamızı sağlar.
        sil.State = EntityState.Deleted;// Bu satır, entity nesnesinin silinmesi gerektiğini belirtiyor.
        db.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
           return _object.SingleOrDefault(filter);
        }

        public void Insert(T entity)
        {
          var ekle = db.Entry(entity);
            ekle.State = EntityState.Added;
            db.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T entity)
        {
          var guncelle = db.Entry(entity);
            guncelle.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
