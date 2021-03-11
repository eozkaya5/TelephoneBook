using TelephoneBook.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TelephoneBook.Permissions
{
    public class TelephoneBookPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(TelephoneBookPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(TelephoneBookPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<TelephoneBookResource>(name);
        }
    }
}
