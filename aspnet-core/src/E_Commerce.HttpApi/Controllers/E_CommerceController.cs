using E_Commerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace E_Commerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class E_CommerceController : AbpControllerBase
{
    protected E_CommerceController()
    {
        LocalizationResource = typeof(E_CommerceResource);
    }
}
