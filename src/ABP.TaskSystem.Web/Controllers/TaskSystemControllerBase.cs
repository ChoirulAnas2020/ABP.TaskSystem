using Abp.AspNetCore.Mvc.Controllers;

namespace ABP.TaskSystem.Web.Controllers
{
    public abstract class TaskSystemControllerBase: AbpController
    {
        protected TaskSystemControllerBase()
        {
            LocalizationSourceName = TaskSystemConsts.LocalizationSourceName;
        }
    }
}