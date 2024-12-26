using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Commands.AboutCommands
{
    public class UpdateAboutCommand //  eğer command sınıflarımız varsa bunların handlerlarını yazabiliriz AboutHandlers klasorünün içine CreateAboutCommandHandler classını olusturuyoruz public sekilde
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
