using System;
using System.Collections.Generic;
using System.Text;

namespace ToUpperHtmlTagsLibrary
{
    public static class ToUpperHtmlTagsHelper
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
                else if (inputHtmlChars[i] == '>')
                {
                    indexesToUpper.Add(i - 1);
                }
            }

            var htmlSpan = new Span<char>(inputHtmlChars);

            for (var i = 0; i < indexesToUpper.Count; i += 2)
            {
                var lowerIndexValue = indexesToUpper[i];
                var upperIndexValue = indexesToUpper[i + 1] - indexesToUpper[i] + 1;
                var currentSlice = htmlSpan.Slice(lowerIndexValue, upperIndexValue);

                for (var j = 0; j < currentSlice.Length; j++)
                {
                    currentSlice[j] = char.ToUpper(currentSlice[j]);
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
