using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstABP.Roles.Dto;

namespace MyFirstABP.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
