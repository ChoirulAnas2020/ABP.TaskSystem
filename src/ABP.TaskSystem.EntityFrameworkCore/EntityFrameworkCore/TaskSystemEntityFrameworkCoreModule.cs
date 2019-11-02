using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ABP.TaskSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(TaskSystemCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class TaskSystemEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TaskSystemEntityFrameworkCoreModule).GetAssembly());
        }
    }
}