using System.Collections.Generic;
using System.Text;

namespace ToUpperHtmlTagsLibraryNetFramework
{
    public static class ToUpperHtmlTagsHelperNetFramework
    {
        public static string ToUpperHtmlTags(string inputHtmlString)
        {
            var inputHtmlChars = new char[inputHtmlString.Length];

            for (var i = 0; i < inputHtmlChars.Length; i++)
            {
                inputHtmlChars[i] = inputHtmlString[i];
            }

            var indexesToUpper = new List<int>();

            for (var i = 0; i < inputHtmlChars.Length; i++)
            {
                if (inputHtmlChars[i] == '<')
                {
                    indexesToUpper.Add(i + 1);
                }
                if (inputHtmlChars[i] == '>')
                {
                    indexesToUpper.Add(i - 1);
                }
            }

            for (var i = 0; i < indexesToUpper.Count; i += 2)
            {
                var lowerIndexValue = indexesToUpper[i];
                var upperIndexValue = indexesToUpper[i + 1];

                for (var j = lowerIndexValue; j <= upperIndexValue; j++)
                {
                    inputHtmlChars[j] = char.ToUpper(inputHtmlChars[j]);
                }
            }

            var htmlStringBuilder = new StringBuilder();
            for (var i = 0; i < inputHtmlChars.Length; i++)
            {
                htmlStringBuilder.Append(inputHtmlChars[i]);
            }

            return htmlStringBuilder.ToString();
        }
    }
}
