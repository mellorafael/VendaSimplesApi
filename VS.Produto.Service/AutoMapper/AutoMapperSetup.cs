using AutoMapper;
using VS.Produto.CommandDTO;

namespace VS.Produto.ViewModel.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<VS.Produto.Domain.Produto, ProdutoViewModel>();
            CreateMap<ProdutoInsertCommandDTO, VS.Produto.Domain.Produto>();
        }
    }
}
