using System;
using System.Collections.Generic;
using System.Text;
using E_Commerce.Localization;
using Volo.Abp.Application.Services;

namespace E_Commerce;

/* Inherit your application services from this class.
 */
public abstract class E_CommerceAppService : ApplicationService
{
    protected E_CommerceAppService()
    {
        LocalizationResource = typeof(E_CommerceResource);
    }
}
