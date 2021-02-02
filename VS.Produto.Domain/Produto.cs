using System;

namespace VS.Produto.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoCusto { get; set; }
        public string Unidade { get; set; }
    }
}
