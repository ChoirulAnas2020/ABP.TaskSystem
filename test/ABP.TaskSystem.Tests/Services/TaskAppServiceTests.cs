using ABP.TaskSystem.Contracts;
using ABP.TaskSystem.DTO;
using Shouldly;
using Xunit;

namespace ABP.TaskSystem.Tests.Services
{
    public class TaskAppServiceTests : TaskSystemTestBase
    {
        private readonly ITaskAppService _taskAppService;

        public TaskAppServiceTests()
        {
            _taskAppService = Resolve<ITaskAppService>();
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_All_Task()
        {
            // Act
            var output = await _taskAppService.GetAll(new GetAllTasksInput());

            // Assert
            output.Items.Count.ShouldBe(3);
        }

        [Fact]
        public async System.Threading.Tasks.Task Should_Get_Filtered_Task()
        {
            // Act
            var output = await _taskAppService.GetAll(new GetAllTasksInput { State = Enums.TaskState.Open });

            // Assert
            output.Items.ShouldAllBe(t => t.State == Enums.TaskState.Open);
        }
    }
}
