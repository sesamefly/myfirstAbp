using System.Threading.Tasks;
using MyFirstABP.Configuration.Dto;

namespace MyFirstABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}