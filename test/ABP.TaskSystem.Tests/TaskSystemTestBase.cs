using System;
using System.Threading.Tasks;
using Abp.TestBase;
using ABP.TaskSystem.EntityFrameworkCore;
using ABP.TaskSystem.Tests.TestDatas;

namespace ABP.TaskSystem.Tests
{
    public class TaskSystemTestBase : AbpIntegratedTestBase<TaskSystemTestModule>
    {
        public TaskSystemTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<TaskSystemDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<TaskSystemDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<TaskSystemDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<TaskSystemDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<TaskSystemDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<TaskSystemDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<TaskSystemDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<TaskSystemDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
