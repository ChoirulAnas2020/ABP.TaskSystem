using Microsoft.EntityFrameworkCore;

namespace ABP.TaskSystem.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<TaskSystemDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for TaskSystemDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
