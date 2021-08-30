namespace ManualMapInjection.Injection
{
    using System;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="Helpers" />.
    /// </summary>
    internal static class Helpers
    {
        /// <summary>
        /// The ToStringAnsi.
        /// </summary>
        /// <param name="buffer">The buffer<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        internal static string ToStringAnsi(byte[] buffer)
        {
            var sb = new StringBuilder();
            foreach (var t in buffer)
            {
                if (t == 0)
                {
                    break;
                }

                sb.Append((char)t);
            }

            return sb.ToString();
        }

        /// <summary>
        /// The _stricmp.
        /// </summary>
        /// <param name="str1">The str1<see cref="char[]"/>.</param>
        /// <param name="str2">The str2<see cref="char[]"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        internal static bool _stricmp(char[] str1, char[] str2)
        {
            var min = Math.Min(str1.Length, str2.Length);
            for (var i = 0; i < min; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }

                if (str1[i] == 0)
                {
                    break;
                }
            }

            return true;
        }
    }
}
