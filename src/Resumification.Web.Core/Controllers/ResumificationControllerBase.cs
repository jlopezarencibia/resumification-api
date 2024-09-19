using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Resumification.Controllers
{
    public abstract class ResumificationControllerBase: AbpController
    {
        protected ResumificationControllerBase()
        {
            LocalizationSourceName = ResumificationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
