using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.TaskSystem.Configuration;
using ABP.TaskSystem.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace ABP.TaskSystem.Web.Startup
{
    [DependsOn(
        typeof(TaskSystemApplicationModule), 
        typeof(TaskSystemEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class TaskSystemWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public TaskSystemWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(TaskSystemConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<TaskSystemNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(TaskSystemApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TaskSystemWebModule).GetAssembly());
        }
    }
}