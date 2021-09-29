using System;

namespace API.Models
{
    public class Tarefa
    {
        public Produto() => Conclusao = DateTime.Now;

        public int Id { get; set; }
        public string Nome { get; set; }
        public float Prazo { get; set; }
        public string Descricao { get; set; }
        public DateTime Conclusao { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | Prazo: {Prazo} | Conclusao: {Conclusao}";
    }
}