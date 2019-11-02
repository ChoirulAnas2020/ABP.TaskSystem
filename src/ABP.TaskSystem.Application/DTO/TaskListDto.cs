using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using ABP.TaskSystem.Entities;
using ABP.TaskSystem.Enums;
using System;

namespace ABP.TaskSystem.DTO
{
    [AutoMapFrom(typeof(Task))]
    public class TaskListDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }
    }

    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }
}
