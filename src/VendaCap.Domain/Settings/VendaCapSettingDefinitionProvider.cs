using Volo.Abp.Settings;

namespace VendaCap.Settings;

public class VendaCapSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(VendaCapSettings.MySetting1));
    }
}
