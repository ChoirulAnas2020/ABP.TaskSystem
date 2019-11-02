using Abp.Application.Services;

namespace ABP.TaskSystem
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class TaskSystemAppServiceBase : ApplicationService
    {
        protected TaskSystemAppServiceBase()
        {
            LocalizationSourceName = TaskSystemConsts.LocalizationSourceName;
        }
    }
}