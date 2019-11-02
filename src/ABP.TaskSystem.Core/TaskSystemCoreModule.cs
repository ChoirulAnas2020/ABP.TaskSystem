using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.TaskSystem.Localization;

namespace ABP.TaskSystem
{
    public class TaskSystemCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            TaskSystemLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TaskSystemCoreModule).GetAssembly());
        }
    }
}