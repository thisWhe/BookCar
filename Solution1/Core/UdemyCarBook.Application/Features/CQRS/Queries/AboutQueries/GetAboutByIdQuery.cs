using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery
    { // Queries de Şartlı listeleme işlemlerinin propları olur

        public GetAboutByIdQuery(int id)

        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
