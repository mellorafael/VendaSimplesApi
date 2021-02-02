using Dapper;
using System.Collections.Generic;
using VS.Infra.Application.data.interfaces;
using VS.Produto.Data.interfaces;

namespace VS.Produto.Data
{
    public class ProdutoRepository : IProdutoRepository
    {
        public IVSConnection VSConn { get; set; }

        public ProdutoRepository(IVSConnection VSConn)
        {
            this.VSConn = VSConn;
        }
        public IEnumerable<VS.Produto.Domain.Produto> GetProdutos()
        {
            var sql = @"SELECT id as Id,
                            nome AS Nome, 
                            preco AS Preco, 
                            preco_custo AS PrecoCusto, 
                            unidade AS Unidade 
                        FROM 
                            Produto";
            return VSConn.Conn.Query<VS.Produto.Domain.Produto>(sql);
        }

        public VS.Produto.Domain.Produto GetProduto(int id)
        {
            var sql = @"SELECT id as Id,
                            nome AS Nome, 
                            preco AS Preco, 
                            preco_custo AS PrecoCusto, 
                            unidade AS Unidade 
                        FROM 
                            Produto
                        WHERE id = @id";
            return VSConn.Conn.QueryFirstOrDefault<VS.Produto.Domain.Produto>(sql, new { id });
        }

        public void DeleteProduto(int id)
        {
            var sql = @" DELETE FROM Produto WHERE id = @id ";
            VSConn.Conn.Execute(sql, new { id });
        }

        public void InsertProduto(VS.Produto.Domain.Produto produto)
        {
            var sql = @" INSERT INTO produto
                                            (nome,
                                             preco,
                                             preco_custo,
                                             unidade)
                                VALUES      (@Nome,
                                             @Preco,
                                             @PrecoCusto,
                                             @Unidade) ";
            VSConn.Conn.Execute(sql, produto);
        }
    }
}
