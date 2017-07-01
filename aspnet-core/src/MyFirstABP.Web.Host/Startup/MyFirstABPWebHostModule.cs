using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyFirstABP.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyFirstABP.Web.Host.Startup
{
    [DependsOn(
       typeof(MyFirstABPWebCoreModule))]
    public class MyFirstABPWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyFirstABPWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyFirstABPWebHostModule).GetAssembly());
        }
    }
}
