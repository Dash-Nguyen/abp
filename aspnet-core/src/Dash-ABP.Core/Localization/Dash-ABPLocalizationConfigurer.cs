using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Dash-ABP.Localization
{
    public static class Dash-ABPLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Dash-ABPConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Dash-ABPLocalizationConfigurer).GetAssembly(),
                        "Dash-ABP.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
