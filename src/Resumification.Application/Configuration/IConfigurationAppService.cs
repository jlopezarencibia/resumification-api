using System.Threading.Tasks;
using Resumification.Configuration.Dto;

namespace Resumification.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
