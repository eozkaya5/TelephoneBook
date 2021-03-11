using Volo.Abp.Settings;

namespace TelephoneBook.Settings
{
    public class TelephoneBookSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TelephoneBookSettings.MySetting1));
        }
    }
}
