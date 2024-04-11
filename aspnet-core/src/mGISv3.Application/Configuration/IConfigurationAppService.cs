using System.Threading.Tasks;
using mGISv3.Configuration.Dto;

namespace mGISv3.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
