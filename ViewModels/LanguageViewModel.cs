using ViewModels.Enumerations;

namespace ViewModels
{
    public class LanguageViewModel
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly int _id;
        private readonly string _cultureInfo;
        private readonly string _displayValue;
        private readonly string _shortcutValue;
        private readonly string _flagEmoji;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public int Id { get => _id; }

        public string CultureInfo { get => _cultureInfo; }

        public string DisplayValue { get => _displayValue; }

        public string ShortcutValue { get => _shortcutValue; }

        public string FlagEmoji { get => _flagEmoji; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public LanguageViewModel(Language language)
        {
            // Inputs
            {
                _id = (int)language;
                _cultureInfo = language.GetCultureInfo();
                _displayValue = language.GetDisplayName();
                _shortcutValue = language.GetShortcutValue();
                _flagEmoji = language.GetEmoji();
            }
        }

        public LanguageViewModel(int languageId) : this((Language)languageId)
        {
        }
    }
}
