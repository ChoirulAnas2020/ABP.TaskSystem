using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABP.TaskSystem.DTO;
using System.Threading.Tasks;

namespace ABP.TaskSystem.Contracts
{
    public interface ITaskAppService : IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input);
    }
}
