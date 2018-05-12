using AgiliBlueFood.Domain.Entities;
using AgiliBlueFood.MVC.ViewModels;
using AutoMapper;

namespace AgiliBlueFood.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<PessoaJuridica, PessoaJuridicaViewModel>();
            Mapper.CreateMap<Pais, PaisViewModel>();
            Mapper.CreateMap<Estado, EstadoViewModel>();
            Mapper.CreateMap<Municipio, MunicipioViewModel>();
            Mapper.CreateMap<Bairro, BairroViewModel>();
            Mapper.CreateMap<TipoLogradouro, TipoLogradouroViewModel>();
            Mapper.CreateMap<Logradouro, LogradouroViewModel>();
            Mapper.CreateMap<PessoaFisica, PessoaFisicaViewModel>();
            Mapper.CreateMap<Usuario, UsuarioViewModel>();

        }
    }
}