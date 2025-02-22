using CSharp301.DataAccessLayer.Abstract;
using CSharp301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class // Generic daldan T classı için miras alacak.
                                                                       // Hata vermesinin sebebi IGemericDal bir interface .Bu interfacein içerisinde bir takım metotlar vardır.
                                                                       // Eğer bu metotlar kullanılıcaksa bu metotların implement edilmesi gerekiyor.
    {
        KampContext context=new KampContext();
        private readonly DbSet<T> _object;//Field
        
        public GenericRepository()
        {
            _object=context.Set<T>();//Generic sitoriy classı çağrıldığı zaman _objecte bir  nesne örneği oluşturulacak.Ve buradan _object nesnesine context sınıfından gönderilmiş entity'i atıyor.(Product,ıd...)
        }
        public void Delete(T entity)
        {
            var deletedEntity=context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;//EnitityState ekleme,sikme,güncelleme ve başka bazı değişikliklere izin veren bir kod bloğudur.
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T entity)
        {
            var addedEntity=context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity=context.Entry(entity);
            updatedEntity.State = EntityState.Modified;//.Net Frameworkte update işlemi yapıyor
            context.SaveChanges();
        }
    }
}
