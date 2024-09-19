using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Resumification.Configuration.Dto;

namespace Resumification.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ResumificationAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
