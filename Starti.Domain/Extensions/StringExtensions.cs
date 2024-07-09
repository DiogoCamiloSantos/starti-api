using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starti.Domain.Extensions
{
    public static class StringExtensions
    {
        public static string ToSnakeCase(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var stringBuilder = new StringBuilder();
            var state = SnakeCaseState.Start;

            for (var i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    switch (state)
                    {
                        case SnakeCaseState.Upper:
                            var hasNext = i + 1 < input.Length;
                            if (i > 0 && hasNext)
                            {
                                var nextChar = input[i + 1];
                                if (!char.IsUpper(nextChar) && nextChar != '_')
                                {
                                    stringBuilder.Append('_');
                                }
                            }
                            break;

                        case SnakeCaseState.Lower:
                        case SnakeCaseState.Start:
                            if (i > 0)
                            {
                                stringBuilder.Append('_');
                            }
                            break;
                    }

                    stringBuilder.Append(char.ToLowerInvariant(input[i]));
                    state = SnakeCaseState.Upper;
                }
                else if (input[i] == '_')
                {
                    stringBuilder.Append('_');
                    state = SnakeCaseState.Start;
                }
                else
                {
                    stringBuilder.Append(input[i]);
                    state = SnakeCaseState.Lower;
                }
            }

            return stringBuilder.ToString();
        }

        private enum SnakeCaseState
        {
            Start,
            Lower,
            Upper
        }
    }
}
