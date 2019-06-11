namespace PortalNoticias.WebApi.Model
{
    public class Noticia : IModelo
    {
        public int Id { get; set; }
        public Autor Autor { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }    
    }
}
