using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstABP.Sessions.Dto;

namespace MyFirstABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
