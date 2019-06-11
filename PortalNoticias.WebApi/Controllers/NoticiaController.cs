using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalNoticias.WebApi.Dtos;
using PortalNoticias.WebApi.Model;
using PortalNoticias.WebApi.Repository;

namespace PortalNoticias.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiaController : ControllerBase
    {
        private readonly NoticiaRepository _repo;
        private readonly IMapper _mapper;
        private readonly PortalNoticiasContext _context;

        public NoticiaController(NoticiaRepository repo, IMapper mapper, PortalNoticiasContext context)
        {
            _repo = repo;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var noticias = await _repo.GetByQtd(10);
                var results = _mapper.Map<NoticiaDto[]>(noticias);
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha ao retornar dados");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var noticia = await _repo.GetById(id);
                var results = _mapper.Map<NoticiaDto>(noticia);
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha ao retornar dados");
            }
        }

        [HttpGet("busca/{texto}")]
        public async Task<IActionResult> Get(string texto)
        {
            try
            {
                var noticias = await _repo.GetByText(texto);
                var results = _mapper.Map<NoticiaDto[]>(noticias);
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha ao retornar dados");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(NoticiaDto model)
        {
            try
            {
                var noticia = _mapper.Map<Noticia>(model);
                _repo.Add(noticia);
                if (await _repo.SaveChangesAsync())
                {
                    return Created($"/api/noticia/{model.Id}", _mapper.Map<NoticiaDto>(noticia));
                }               
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha ao inserir Dados");
            }

            return BadRequest();
        }
    }
}
