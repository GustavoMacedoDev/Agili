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
            kernel.Bind<ILoginAppService>().To<LoginAppService>();
            kernel.Bind<IPaisAppService>().To<PaisAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IPessoaJuridicaService>().To<PessoaJuridicaService>();
            kernel.Bind<ILoginService>().To<LoginService>();
            kernel.Bind<IPaisService>().To<PaisService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IPessoaJuridicaRepository>().To<PessoaJuridicaRepository>();
            kernel.Bind<ILoginRepository>().To<LoginRepository>();
            kernel.Bind<IPaisRepository>().To<PaisRepository>();
        }        
    }
}
