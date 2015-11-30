[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(EntityFirstAppWeb.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(EntityFirstAppWeb.App_Start.NinjectWebCommon), "Stop")]

namespace EntityFirstAppWeb.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using EntityFirstAppService.Service_Interface;
    using EntityFirstAppService.Service;
    using EntityFirstApp.Repository_Interface;
    using EntityFirstApp.Repository;
    using EntityFirstApp.Context;
    using EntityFirstApp.IContext;
    using System.Data.Entity;

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
                System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new Ninject.WebApi.DependencyResolver.NinjectDependencyResolver(kernel);
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
            //kernel.Bind<AppContext>().ToSelf().InSingletonScope();
            //kernel.Bind<AppContext>().ToSelf().InRequestScope();
            //kernel.Bind<IUnitOfWork>().ToMethod(ctx => ctx.Kernel.Get<DatabaseContext>());
            //kernel.Bind<DbContext>().ToMethod(ctx => ctx.Kernel.Get<AppContext>());
            //kernel.Bind<IDatabaseFactory>().To<DatabaseFactory>();
            kernel.Bind(typeof(IDatabaseFactory<>)).To(typeof(DatabaseFactory<>));
            kernel.Bind<IDisposable>().To<Disposable>();

            kernel.Bind<IUserService>().To<UserService>();
            kernel.Bind<IUserRepository>().To<UserRepository>();

            kernel.Bind<IVideoService>().To<VideoService>();
            kernel.Bind<IVideoRepository>().To<VideoRepository>();
        }        
    }
}
