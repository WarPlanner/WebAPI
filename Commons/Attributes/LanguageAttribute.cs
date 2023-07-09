namespace Commons.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class LanguageAttribute : Attribute
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly string name;
        private readonly string cultureInfo;
        private readonly string emoji;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public string Name { get => name; }

        public string CultureInfo { get => cultureInfo; }

        public string Emoji { get => emoji; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public LanguageAttribute(string name, string cultureInfo, string emoji)
        {
            this.name = name;
            this.cultureInfo = cultureInfo;
            this.emoji = emoji;
        }
    }
}
