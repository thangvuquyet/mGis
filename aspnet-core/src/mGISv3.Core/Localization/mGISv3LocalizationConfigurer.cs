using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace mGISv3.Localization
{
    public static class mGISv3LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(mGISv3Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(mGISv3LocalizationConfigurer).GetAssembly(),
                        "mGISv3.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
