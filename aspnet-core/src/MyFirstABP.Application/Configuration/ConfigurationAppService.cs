using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyFirstABP.Configuration.Dto;

namespace MyFirstABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyFirstABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
