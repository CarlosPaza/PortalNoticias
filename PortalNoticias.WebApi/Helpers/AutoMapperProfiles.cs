using AutoMapper;
using PortalNoticias.WebApi.Dtos;
using PortalNoticias.WebApi.Model;

namespace PortalNoticias.WebApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Noticia, NoticiaDto>().ReverseMap();
            CreateMap<Autor, AutorDto>().ReverseMap();
        }
    }
}
