using Abp.EntityFrameworkCore;
using ABP.TaskSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace ABP.TaskSystem.EntityFrameworkCore
{
    public class TaskSystemDbContext : AbpDbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskSystemDbContext(DbContextOptions<TaskSystemDbContext> options) 
            : base(options)
        {

        }
    }
}
