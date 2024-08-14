

using System.Text.RegularExpressions;

namespace CompanionDomain.Objects
{
    public static partial class RegularExpressions
    {
        [GeneratedRegex("[^\\w\\-_]")]
        //^ (match all) \w (word characters) \- (hyphens) _ (and underscores)
        public static partial Regex InvalidCharactersRegex();

    }
}
