using System.Collections.Generic;

namespace VS.Produto.Data.interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<VS.Produto.Domain.Produto> GetProdutos();
        VS.Produto.Domain.Produto GetProduto(int id);
        void DeleteProduto(int id);
        void InsertProduto(VS.Produto.Domain.Produto produto);
    }
}
