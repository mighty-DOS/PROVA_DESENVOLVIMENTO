using System;

namespace API.Models
{
    public class Tarefa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public float Prazo { get; set; }
        public string Descricao { get; set; }
        public DateTime Conclusao { get; set; }

    }
}