using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalNoticias.WebApi.Dtos;
using PortalNoticias.WebApi.Model;
using PortalNoticias.WebApi.Repository;
using System;
using System.Threading.Tasks;

namespace PortalNoticias.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly AutorRepository _repo;
        private readonly IMapper _mapper;
        private readonly PortalNoticiasContext _context;

        public AutorController(AutorRepository repo, IMapper mapper, PortalNoticiasContext context)
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
                var autor = await _repo.GetByQtd(0);
                var results = _mapper.Map<AutorDto[]>(autor);
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
                var autor = await _repo.GetById(id);
                var results = _mapper.Map<AutorDto>(autor);
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
                var autor = await _repo.GetByText(texto);
                var results = _mapper.Map<AutorDto[]>(autor);
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha ao retornar dados");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(AutorDto model)
        {
            try
            {
                var autor = _mapper.Map<Autor>(model);
                _repo.Add(autor);
                if (await _repo.SaveChangesAsync())
                {
                    return Created($"/api/autor/{model.Id}", _mapper.Map<AutorDto>(autor));
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
