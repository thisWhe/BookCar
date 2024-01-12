using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly CarBookContext _context; // CarBookContext sınıfından bi tane _context fieldi ornekledik

        public Repository(CarBookContext context) //  dependency injection uygulayabilmek icin class yazısının üstüne gelip ctrl + . yapıp generate constructor... yazısına basıp ok diyip yapıcı metot olarak buraya gelmis oldu
        {
            _context = context; // bunun üzerinden diğer metotlarımın içerisini dolduruyo olucaz
        }

        public async Task CreateAsync(T entity)   // bunları iplement edim metotların icini doldurmak icin hazır hale geldi

        {
            // T ye göre ayarla ondan sonra add ve entityden gelen değer
            _context.Set<T>().Add(entity);  // bu metot şu an kaydetme işlemini gerceklestiriyo olucak
          await  _context.SaveChangesAsync();
        }


        public async Task<List<T>> GettAllAsync()
        {
            return await _context.Set<T>().ToListAsync(); // geriye bütün listeyi döndür 
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id); // idye göre bul
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity); // entityden gelen değeri kaldır
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
           _context.Set<T>().Update(entity); // entityden gelen değer
            await _context.SaveChangesAsync();
        }

        // repository sınıfımız hazır hale geldi
    }
}
