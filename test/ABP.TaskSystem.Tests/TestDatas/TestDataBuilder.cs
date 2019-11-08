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
            _context.Tasks.AddRange(
                new Entities.Task("Wake up", "Wake up at 6 Morning"),
                new Entities.Task("Take a bath", "Bath with playing game"),
                new Entities.Task("Order Grab", "Order Grab from Boarding to Office"));


        }
    }
}