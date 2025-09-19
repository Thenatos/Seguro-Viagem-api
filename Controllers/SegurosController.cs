using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using SeguroViagem.Api.Dados;
using SeguroViagem.Api.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguroViagem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegurosController : ControllerBase
    {
        private readonly AppDbContext _context;

        //Construtor que recebe o contexto do banco de dados via Injeção de Dependência.
        public SegurosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        // Endpoint para LISTAR todos os seguros.
        public async Task<ActionResult<IEnumerable<Seguro>>> GetSeguros()
        {
            return await _context.Seguros.ToListAsync();
        }


        [HttpGet("{id}")]
        // Endpoint para OBTER um seguro específico pelo ID.
        public async Task<ActionResult<Seguro>> GetSeguro(int id)
        {
            var seguro = await _context.Seguros.FindAsync(id);

            if (seguro == null)
            {
                return NotFound();
            }

            return seguro;
        }


        [HttpPut("{id}")]
        // Endpoint para ATUALIZAR um seguro existente.
        public async Task<IActionResult> PutSeguro(int id, Seguro seguro)
        {
            if (id != seguro.Id)
            {
                return BadRequest();
            }

            _context.Entry(seguro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeguroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpPost]
        // Endpoint para CRIAR um novo seguro.
        public async Task<ActionResult<Seguro>> PostSeguro(Seguro seguro)
        {
            _context.Seguros.Add(seguro);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSeguro), new { id = seguro.Id }, seguro);
        }


        [HttpDelete("{id}")]
        // Endpoint para DELETAR um seguro existente.
        public async Task<IActionResult> DeleteSeguro(int id)
        {
            var seguro = await _context.Seguros.FindAsync(id);
            if (seguro == null)
            {
                return NotFound();
            }

            _context.Seguros.Remove(seguro);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // Método auxiliar para verificar se um seguro existe no banco de dados.
        private bool SeguroExists(int id)
        {
            return _context.Seguros.Any(e => e.Id == id);
        }
    }
}