using ABP.TaskSystem.DTO;
using ABP.TaskSystem.Enums;
using System.Collections.Generic;

namespace ABP.TaskSystem.Web.ViewModels
{
    public class IndexViewModel
    {
        public IReadOnlyList<TaskListDto> Tasks { get; }

        public IndexViewModel(IReadOnlyList<TaskListDto> tasks)
        {
            Tasks = tasks;
        }

        public string GetTaskLabel(TaskListDto task)
        {
            switch (task.State)
            {
                case TaskState.Open:
                    return "label-success";

                default:
                    return "label-default";
            }
        }
    }
}
