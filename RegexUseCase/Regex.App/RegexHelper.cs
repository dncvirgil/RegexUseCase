using System.Text.RegularExpressions;

namespace MyRegex.App
{
    public static class RegexHelper
    {
        public static bool ValidateString(string input, int maxLength)
        {
            string pattern = $@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@\[\]^_`{{|}}~])(?!.*\s).{{1,{maxLength}}}$";
            return Regex.IsMatch(input, pattern);
        }
    }
}