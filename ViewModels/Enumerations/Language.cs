using Commons.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ViewModels.Enumerations
{
    public enum Language
    {
        [Display(Name = "Français")]
        [Language("fr", "fr-FR", "🇫🇷")]
        FRENCH = 1,

        [Display(Name = "English")]
        [Language("en", "en-US", "🇬🇧")]
        ENGLISH = 2,
    }

    public static class LanguageExtensions
    {
        public static string GetCultureInfo(this Language language)
        {
            return language
                .GetType()?
                .GetMember(language.ToString())?
                .First()?
                .GetCustomAttribute<LanguageAttribute>()?
                .CultureInfo ?? throw new ArgumentNullException(nameof(language));
        }

        public static string GetDisplayName(this Language language)
        {
            return language
                .GetType()?
                .GetMember(language.ToString())?
                .First()?
                .GetCustomAttribute<DisplayAttribute>()?
                .Name ?? throw new ArgumentNullException(nameof(language));
        }

        public static string GetEmoji(this Language language)
        {
            return language
                .GetType()?
                .GetMember(language.ToString())?
                .First()?
                .GetCustomAttribute<LanguageAttribute>()?
                .Emoji ?? throw new ArgumentNullException(nameof(language));
        }

        public static string GetShortcutValue(this Language language)
        {
            return language
                .GetType()?
                .GetMember(language.ToString())?
                .First()?
                .GetCustomAttribute<LanguageAttribute>()?
                .Name ?? throw new ArgumentNullException(nameof(language));
        }
    }
}
