using System.ComponentModel.DataAnnotations;

namespace PortalNoticias.WebApi.Dtos
{
    public class NoticiaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Autor é obrigatório")]
        public AutorDto Autor { get; set; }

        [Required(ErrorMessage = "Título é obrigatório")]
        [StringLength(255, ErrorMessage = "Título deve conter no máximo 255 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Texto é obrigatório")]
        public string Texto { get; set; }
    }
}
