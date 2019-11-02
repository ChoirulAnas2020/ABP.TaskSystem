using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ABP.TaskSystem.EntityFrameworkCore
{
    public class TaskSystemDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public TaskSystemDbContext(DbContextOptions<TaskSystemDbContext> options) 
            : base(options)
        {

        }
    }
}
