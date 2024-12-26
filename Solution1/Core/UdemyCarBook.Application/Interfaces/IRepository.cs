using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        //listeleme işlemi için;
        Task<List<T>> GettAllAsync();

        Task<T> GetByIdAsync(int id); // Id'ye gore getirme islemi için
      
        Task CreateAsync(T entity); // daha sonra listeleme islemi icin. / T türünde bir entity alıcak

        Task UpdateAsync(T entity);

        Task RemoveAsync(T entity); // T tipinde entity gonderiyoruz
       

        // IRepository Interfacei olusturduk burası bizim bütün entitylerimizin temel olarak kullanıcagı 5 temel metot
    }
}
