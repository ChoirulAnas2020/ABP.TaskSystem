using ABP.TaskSystem.Contracts;
using ABP.TaskSystem.DTO;
using ABP.TaskSystem.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ABP.TaskSystem.Web.Controllers
{
    public class TasksController : TaskSystemControllerBase
    {
        private readonly ITaskAppService _taskAppService;

        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async System.Threading.Tasks.Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items);

            return View(model);
        }
    }
}
