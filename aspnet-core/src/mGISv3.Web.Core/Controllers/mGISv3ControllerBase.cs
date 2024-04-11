using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace mGISv3.Controllers
{
    public abstract class mGISv3ControllerBase: AbpController
    {
        protected mGISv3ControllerBase()
        {
            LocalizationSourceName = mGISv3Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
