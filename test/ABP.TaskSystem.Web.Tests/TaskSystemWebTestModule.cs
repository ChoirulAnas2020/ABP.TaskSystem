using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.TaskSystem.Web.Startup;
namespace ABP.TaskSystem.Web.Tests
{
    [DependsOn(
        typeof(TaskSystemWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class TaskSystemWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TaskSystemWebTestModule).GetAssembly());
        }
    }
}