using Abp.AspNetCore.Mvc.Views;

namespace ABP.TaskSystem.Web.Views
{
    public abstract class TaskSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected TaskSystemRazorPage()
        {
            LocalizationSourceName = TaskSystemConsts.LocalizationSourceName;
        }
    }
}
