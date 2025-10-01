using AtividadeAPI.DataContexts;
using AtividadeAPI.Models;
using AtividadeAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace AtividadeAPI.Controllers
{
   
    [Route("/empresas")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmpresaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos([FromQuery] string? search, [FromQuery] string? cnpj, [FromQuery] string? razaoSocial, [FromQuery] string? nomeFantasia)
        {
            var query = _context.Empresas.AsQueryable();
           
            if (search is not null)
            {
                query = query.Where(x => x.RazaoSocial.Contains(search));
            }
            if (cnpj is not null)
            {
                query = query.Where(x => x.Cnpj.Equals(cnpj));
            }
            if (razaoSocial is not null)
            {
                query = query.Where(x => x.Telefone.Equals(razaoSocial));
                if (nomeFantasia is not null)
                {
                    query = query.Where(x => x.Email.Equals(nomeFantasia));
                }
            }

           var empresas = await query.Select(x => new
            {
                x.RazaoSocial,
                x.NomeFantasia,
                x.Cnpj,
                x.Telefone,
                x.Email

            }).ToListAsync();

            return Ok(empresas);
        }


        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] EmpresaDto novaEmpresa)
        {
            var empresa = new Empresa() { RazaoSocial = novaEmpresa.RazaoSocial, NomeFantasia = novaEmpresa.NomeFantasia, Cnpj = novaEmpresa.Cnpj, Inscricao = novaEmpresa.Inscricao, Telefone = novaEmpresa.Telefone, Email = novaEmpresa.Email, Cidade = novaEmpresa.Cidade, UF = novaEmpresa.UF, Cep = novaEmpresa.Cep, DataCadastro = DateTime.Now};

            await _context.AddAsync(empresa);
            await _context.SaveChangesAsync();

            return Created("", empresa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] EmpresaDto atualizacaoEmpresa)
        {
            var empresa = await _context.Empresas.FirstOrDefaultAsync(x => x.Id == id);
            if (atualizacaoEmpresa is null)
            {
                return NotFound();
            }
            empresa.RazaoSocial = atualizacaoEmpresa.RazaoSocial;
            empresa.Cnpj = atualizacaoEmpresa.Cnpj;
            empresa.Inscricao = atualizacaoEmpresa.Inscricao;
            empresa.Telefone = atualizacaoEmpresa.Telefone;
            empresa.Email = atualizacaoEmpresa.Email;
            empresa.Cidade = atualizacaoEmpresa.Cidade;
            empresa.UF = atualizacaoEmpresa.UF;
             
            _context.Empresas.Update(empresa);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Remover(int id)
        {
            var empresa = await _context.Empresas.FindAsync(id);
            if(empresa is null)
            {
                return NotFound("Empresa não encontrada!");
            }
            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
