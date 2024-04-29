using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace E_Commerce;

[Dependency(ReplaceServices = true)]
public class E_CommerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "E_Commerce";
}
