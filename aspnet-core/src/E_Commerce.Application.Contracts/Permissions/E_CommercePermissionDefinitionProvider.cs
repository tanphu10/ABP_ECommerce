using E_Commerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace E_Commerce.Permissions;

public class E_CommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(E_CommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(E_CommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<E_CommerceResource>(name);
    }
}
