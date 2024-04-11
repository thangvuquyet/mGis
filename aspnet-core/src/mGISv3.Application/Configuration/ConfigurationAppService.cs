using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using mGISv3.Configuration.Dto;

namespace mGISv3.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : mGISv3AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
