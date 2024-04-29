using Volo.Abp.Settings;

namespace E_Commerce.Settings;

public class E_CommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(E_CommerceSettings.MySetting1));
    }
}
