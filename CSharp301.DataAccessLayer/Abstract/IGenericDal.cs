using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T: class//T değeri mutlaka bir class olacak.
                                                  //dışardan harici bir metot,interface veya başka bir bileşen gelmeyecek. Sadce sınıf ile çalışalacak
                                                  //T değeri order product gibi tüm entity değerleri alacak.
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();//Bütün verileri getirecek.
        T GetById(int id);//Dışardan id'yi alır.
    }
}
