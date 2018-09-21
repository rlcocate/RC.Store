using System;

namespace RC.Store.UI.Models
{
    public class Produto
    {          
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Tipo { get; set; }

        public short Quantidade { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}