using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testes.Entites;

namespace testes.Dao.ITarefas
{
    public interface ITarefas
    {    
        public Tarefa ObterTarefaPorId(int Id);
        public Tarefa AtualizarTarefa(Tarefa Tarefa,int id);
        public void  DeleteTarefa(int id);
        public List<Tarefa> ObterTodasTarefas();   
        public Tarefa ObterPorTitulo(string titulo);   
        public Tarefa ObterPorData(DateTime data);
        public Tarefa ObterPorStatus(int statusTarefa);
        public void PostTarefa(Tarefa tarefa);

    }
}