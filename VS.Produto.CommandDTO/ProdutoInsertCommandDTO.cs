using System;

namespace VS.Produto.CommandDTO
{
    public class ProdutoInsertCommandDTO
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoCusto { get; set; }
        public string Unidade { get; set; }
    }
}
