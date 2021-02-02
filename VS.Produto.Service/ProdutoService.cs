using AutoMapper;
using System.Collections.Generic;
using VS.Produto.CommandDTO;
using VS.Produto.ViewModel;
using VS.Produto.Data.interfaces;

namespace VS.Produto.Application
{
    public class ProdutoService
    {
        IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;
        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }
        public IEnumerable<ProdutoViewModel> BuscarTodosProdutos()
        {
            return _mapper.Map<IEnumerable<VS.Produto.Domain.Produto>, IEnumerable<ProdutoViewModel>>(_produtoRepository.GetProdutos());
        }

        public ProdutoViewModel BuscarProdutoPorId(int id)
        {
            return _mapper.Map<ProdutoViewModel>(_produtoRepository.GetProduto(id));
        }

        public void DeletarProdutoPorId(int id)
        {
            _produtoRepository.DeleteProduto(id);
        }

        public void InserirProduto(ProdutoInsertCommandDTO produto)
        {
            var Produto = _mapper.Map<VS.Produto.Domain.Produto>(produto);
            _produtoRepository.InsertProduto(Produto);
        }
    }
}
