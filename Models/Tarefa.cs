using System;

namespace API.Models
{
    public class Tarefa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Prazo { get; set; }
        public string Descricao { get; set; }
        public DateTime Conclusão { get; set; }

    }
}