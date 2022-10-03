using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testes.Context;
using testes.Entites;

namespace testes.Dao.ITarefas
{
    public class TarefasRepository : ITarefas
    {
        private readonly TarefasContext _context;
        public TarefasRepository(TarefasContext context)
        {
            _context = context;
        }
        public Tarefa ObterTarefaPorId(int id)
        {
            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Id == id);
            return tarefa;
        }

        public List<Tarefa> ObterTodasTarefas()
        {
            return _context.Tarefas.ToList();
        }

        public Tarefa ObterPorTitulo(string titulo)
        {
            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Titulo == titulo);
            return tarefa;
        }
        public Tarefa AtualizarTarefa(Tarefa tarefa, int id)
        {
            var result = _context.Tarefas.Where(x => x.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.Titulo = tarefa.Titulo;
                result.Descricao = tarefa.Descricao;
                result.Data = tarefa.Data;
                result.Status = tarefa.Status;

                _context.Update(result);
                _context.SaveChanges();
                return tarefa;
            }
            else
            {
                return null;
            }
        }

        public void DeleteTarefa(int id)
        {
            var tarefa = _context.Tarefas.Single(x => x.Id == id);
            if (tarefa == null)
            {
                _context.Tarefas.Remove(tarefa);
                _context.SaveChangesAsync();               
            }
        }

        public Tarefa ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.SingleOrDefault(x => x.Data.Date == data.Date);
            return tarefa;
        }

        public Tarefa ObterPorStatus(int statusTarefa)
        {
            var Tarefa = _context.Tarefas.Where(x => x.Status == (StatusTarefa)statusTarefa).SingleOrDefault();
             return Tarefa;
        }

        public void PostTarefa(Tarefa tarefa)
        {            
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();

            
        }
    }
}