using ABP.TaskSystem.Configuration;
using ABP.TaskSystem.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABP.TaskSystem.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class TaskSystemDbContextFactory : IDesignTimeDbContextFactory<TaskSystemDbContext>
    {
        public TaskSystemDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TaskSystemDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(TaskSystemConsts.ConnectionStringName)
            );

            return new TaskSystemDbContext(builder.Options);
        }
    }
}