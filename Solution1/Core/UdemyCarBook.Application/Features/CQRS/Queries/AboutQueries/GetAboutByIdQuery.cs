using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery
    { // Queries Şartlı listeleme işlemlerinin propları olur

        public GetAboutByIdQuery(int id) //Idyi cagırıcagımız için class yazısının üstüne geliyoruz ctrl + . diyip generator constructora basıyoruz yapıcı metodumuz oluyor

        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
