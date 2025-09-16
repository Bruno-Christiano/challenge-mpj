using System.Collections.Generic;
using DevelopmentChallenge.Data.Enum;

namespace DevelopmentChallenge.Data.Classes
{
    public static class LanguageDictionary
    {
        private static readonly Dictionary<string, Dictionary<string, string>> _translations = new();

        public static void Register(string language, Dictionary<string, string> translations)
        {
            _translations[language] = translations;
        }
        

        public static void Register(LanguageEnum language, Dictionary<string, string> translations)
        {
            _translations[ToCode(language)] = translations;
        }

        public static string Translate(LanguageEnum language, string key)
        {
            var code = ToCode(language);
            if (_translations.ContainsKey(code) && _translations[code].ContainsKey(key))
                return _translations[code][key];
            return key;
        }

        private static string ToCode(LanguageEnum language)
        {
            return language switch
            {
                LanguageEnum.EN => "en",
                LanguageEnum.ES => "es",
                LanguageEnum.IT => "it",
                _ => "en"
            };
        }
    }
}
