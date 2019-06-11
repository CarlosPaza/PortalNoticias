using System.ComponentModel.DataAnnotations;

namespace PortalNoticias.WebApi.Dtos
{
    public class AutorDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do autor obrigatório")]
        [StringLength(255, ErrorMessage = "Nome do autor deve conter no máximo 255 caracteres")]
        public string Nome { get; set; }
    }
}
