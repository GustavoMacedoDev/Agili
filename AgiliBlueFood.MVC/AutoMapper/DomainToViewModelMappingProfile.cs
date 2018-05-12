using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;

namespace AgiliBlueFood.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<PessoaJuridicaViewModel, PessoaJuridica>();
            Mapper.CreateMap<PaisViewModel, Pais>();
            Mapper.CreateMap<EstadoViewModel, Estado>();
            Mapper.CreateMap<MunicipioViewModel, Municipio>();
            Mapper.CreateMap<BairroViewModel, Bairro>();
            Mapper.CreateMap<TipoLogradouroViewModel, TipoLogradouro>();
            Mapper.CreateMap<LogradouroViewModel, Logradouro>();
            Mapper.CreateMap<PessoaJuridicaViewModel, Logradouro>();
            Mapper.CreateMap<PessoaFisicaViewModel, PessoaFisica>();
            Mapper.CreateMap<UsuarioViewModel, Usuario>();

        }

    }
}