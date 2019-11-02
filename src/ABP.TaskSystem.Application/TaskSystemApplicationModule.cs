using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ABP.TaskSystem
{
    [DependsOn(
        typeof(TaskSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TaskSystemApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TaskSystemApplicationModule).GetAssembly());
        }
    }
}