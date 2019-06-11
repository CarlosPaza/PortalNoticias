using System.Collections.Generic;

namespace PortalNoticias.WebApi.Model
{
    public class Autor : IModelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IList<Noticia> Noticias { get; set; }

        public Autor(string nome)
        {
            Nome = nome;
        }
    }
}
