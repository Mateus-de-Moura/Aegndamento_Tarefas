using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using testes.Entites;
using testes.Context;
using testes.Dao;
using testes.Dao.ITarefas;

namespace testes.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly TarefasContext _context;
        private readonly ITarefas _tarefa;

        public TarefasController(TarefasContext context, ITarefas tarefa)
        {
            _context = context;
            _tarefa = tarefa;
        }

        [HttpGet("{id}")]
        public IActionResult GetTarefa(int id)
        {
            var tarefa = _tarefa.ObterTarefaPorId(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarTarefa([FromBody] Tarefa tarefa, int id)
        {
            if (id != 0)
            {
                _tarefa.AtualizarTarefa(tarefa, id);
                return Ok(_tarefa.ObterTarefaPorId(id));
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTarefa(int id)
        {
            var tarefa = _tarefa.ObterTarefaPorId(id);

            if (tarefa != null)
            {
                _tarefa.DeleteTarefa(id);
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }
        [HttpGet("ObterTodos")]
        public IActionResult GetTarefas()
        {
            return Ok(_tarefa.ObterTodasTarefas());
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string Titulo)
        {
            return Ok(_tarefa.ObterPorTitulo(Titulo));
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            return Ok(_tarefa.ObterPorData(data));
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(int status)
        {
            return Ok(_tarefa.ObterPorStatus(status));
        }

        [HttpPost]
        public IActionResult PostTarefa(Tarefa tarefa)
        {
            _tarefa.PostTarefa(tarefa);
            var result = _tarefa.ObterPorTitulo(tarefa.Titulo);
            return Ok(tarefa);
        }
    }
}
