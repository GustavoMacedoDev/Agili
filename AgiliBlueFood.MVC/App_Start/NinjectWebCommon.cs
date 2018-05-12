[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(AgiliBlueFood.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(AgiliBlueFood.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace AgiliBlueFood.MVC.App_Start
{
    using System;
    using System.Web;
    using AgiliBlueFood.Application;
    using AgiliBlueFood.Application.Interface;
    using AgiliBlueFood.Domain.Interfaces;
    using AgiliBlueFood.Domain.Interfaces.Repositories;
    using AgiliBlueFood.Domain.Interfaces.Services;
    using AgiliBlueFood.Domain.Services;
    using AgiliBlueFood.Infra.Data.Repositories;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            //Classes genericas
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            //classes de entidades da App
            kernel.Bind<IPessoaJuridicaAppService>().To<PessoaJuridicaAppService>();
            kernel.Bind<IPaisAppService>().To<PaisAppService>();
            kernel.Bind<IEstadoAppService>().To<EstadoAppService>();
            kernel.Bind<IMunicipioAppService>().To<MunicipioAppService>();
            kernel.Bind<IBairroAppService>().To<BairroAppService>();
            kernel.Bind<ITipoLogradouroAppService>().To<TipoLogradouroAppService>();
            kernel.Bind<ILogradouroAppService>().To<LogradouroAppService>();
            kernel.Bind<IPessoaFisicaAppService>().To<PessoaFisicaAppService>();
            kernel.Bind<IUsuarioAppService>().To<UsuarioAppService>();


            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IPessoaJuridicaService>().To<PessoaJuridicaService>();
            kernel.Bind<IPaisService>().To<PaisService>();
            kernel.Bind<IEstadoService>().To<EstadoService>();
            kernel.Bind<IMunicipioService>().To<MunicipioService>();
            kernel.Bind<IBairroService>().To<BairroService>();
            kernel.Bind<ITipoLogradouroService>().To<TipoLogradouroService>();
            kernel.Bind<ILogradouroService>().To<LogradouroService>();
            kernel.Bind<IPessoaFisicaService>().To<PessoaFisicaService>();
            kernel.Bind<IUsuarioService>().To<UsuarioService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IPessoaJuridicaRepository>().To<PessoaJuridicaRepository>();
            kernel.Bind<IPaisRepository>().To<PaisRepository>();
            kernel.Bind<IEstadoRepository>().To<EstadoRepository>();
            kernel.Bind<IMunicipioRepository>().To<MunicipioRepository>();
            kernel.Bind<IBairroRepository>().To<BairroRepository>();
            kernel.Bind<ITipoLogradouroRepository>().To<TipoLogradouroRepository>();
            kernel.Bind<ILogradouroRepository>().To<LogradouroRepository>();
            kernel.Bind<IPessoaFisicaRepository>().To<PessoaFisicaRepository>();
            kernel.Bind<IUsuarioRepository>().To<UsuarioRepository>();
        }        
    }
}
