using Autofac;
using System.Reflection;

namespace MakeMoney.WebApi {
    /// <summary>
    /// autofac 
    /// </summary>
    public class MakeMoneyWebApiModule : Autofac.Module {
        /// <summary>
        /// 
        /// </summary>
        public MakeMoneyWebApiModule() {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder) {
            builder.RegisterAssemblyTypes(Assembly.LoadFile($@"{Environment.CurrentDirectory}\MakeMoney.EntityFrameworkCore.dll"))
                .Where(a =>  a.Name.EndsWith("Repository")).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.LoadFile($@"{Environment.CurrentDirectory}\MakeMoney.Domain.dll"))
             .Where(a => a.Name.EndsWith("Service") || a.Name.EndsWith("Repository")).AsImplementedInterfaces();
        }
    }
}
