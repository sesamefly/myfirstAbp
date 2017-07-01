using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyFirstABP.Controllers
{
    public abstract class MyFirstABPControllerBase: AbpController
    {
        protected MyFirstABPControllerBase()
        {
            LocalizationSourceName = MyFirstABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}