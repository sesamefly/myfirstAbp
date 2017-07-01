using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstABP.Authorization;

namespace MyFirstABP
{
    [DependsOn(
        typeof(MyFirstABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyFirstABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyFirstABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstABPApplicationModule).GetAssembly());
        }
    }
}