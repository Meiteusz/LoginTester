using Models;
using Models.Interfaces;
using Ninject;
using Ninject.Modules;
using System.Reflection;

namespace InjectionModules
{
    public class UserModule : NinjectModule // change this to Bindings on Controller project
    {
        public override void Load()
        {
            Bind<IUser>().To<User>();
        }

        public static IUser Configure()
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel.Get<IUser>();
        }
    }
}
