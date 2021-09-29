using System;

namespace API.Models
{
    public class Tarefa
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Prazo { get; set; }
        public string Descricao { get; set; }
        public float Conclusao { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | Prazo: {Prazo} | Descricao: {Descricao} | Conclusao: {Conclusao}";
    }
}