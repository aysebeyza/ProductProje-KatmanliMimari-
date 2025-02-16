using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductProjeData.Abstract
{
    //Veritabanı işlemleri için ortak bir yapı oluşturuyoruz. 
    // bir Generic (Genel) Repository Arayüzü tanımlar.
    public interface IRepository<T>   //T yerine Product Category Order kullanılabilir.
    {
        List<T> List(); //Veritabanındaki tüm kayıtları getirir.
        T Get(Expression<Func<T, bool>> filter); //Belirtilen bir şarta göre tek bir kayıt döndürür.
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> List(Expression<Func<T, bool>> filter);//Belirli bir şarta göre birden fazla kayıt döndürür.
    }
}
