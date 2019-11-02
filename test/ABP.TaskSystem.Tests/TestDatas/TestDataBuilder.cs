using ABP.TaskSystem.EntityFrameworkCore;

namespace ABP.TaskSystem.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly TaskSystemDbContext _context;

        public TestDataBuilder(TaskSystemDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}