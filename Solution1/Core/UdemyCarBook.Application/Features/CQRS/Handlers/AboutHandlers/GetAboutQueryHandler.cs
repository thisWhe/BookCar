using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Results.AboutResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryHandler(IRepository<About> repository) // Listenin içinde GettAllAsync var bunun verileri de Aboutun icinden gelicek
        {
            _repository = repository;
        }

        public async Task<List<GetAboutQueryResult>> Handle()
        {
            var values = await _repository.GettAllAsync(); // bu bize sorunsuz sekilde tüm verileri listeliceki
            return values.Select(x => new GetAboutQueryResult
            {/// AboutID ye x'den gelen değer atansın / x ise listemizden gelen verileri tutucak / Listenin içinde GettAllAsync var bunun verileri de Aboutun icinden gelicek
                AboutID = x.AboutID,// parantezler icine ctrl bosluk yapıyoruz bize gelen propları goruyoruz  GetAboutQueryResult'daki proplar
                Description = x.Description,
                Title = x.Title,
                ImageUrl = x.ImageUrl,               
            }).ToList();        
        }
    }
}
