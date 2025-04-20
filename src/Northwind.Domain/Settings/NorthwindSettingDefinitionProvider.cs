using Volo.Abp.Settings;

namespace Northwind.Settings;

public class NorthwindSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NorthwindSettings.MySetting1));
    }
}
