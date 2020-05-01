/*
==============================================================================
Copyright © Jason Drawdy 

All rights reserved.

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

Except as contained in this notice, the name of the above copyright holder
shall not be used in advertising or otherwise to promote the sale, use or
other dealings in this Software without prior written authorization.
==============================================================================
*/

#region Imports

using System;
using System.Text;

#endregion
namespace Confetti
{
    public class Utils
    {
        #region Methods

        /// <summary>
        /// Converts a byte array into a string using a specific encoding style.
        /// </summary>
        /// <param name="input">The data to convert into a string.</param>
        /// <param name="style">The encoding style to use.</param>
        public static string GetString(byte[] input, Styles.EncodingStyle style = Styles.EncodingStyle.Default)
        {
            StringBuilder sb = new StringBuilder();
            switch (style)
            {
                case Styles.EncodingStyle.Default:
                    sb.Append(Encoding.Default.GetString(input));
                    break;
                case Styles.EncodingStyle.ASCII:
                    sb.Append(Encoding.ASCII.GetString(input));
                    break;
                case Styles.EncodingStyle.UTF7:
                    sb.Append(Encoding.UTF7.GetString(input));
                    break;
                case Styles.EncodingStyle.UTF8:
                    sb.Append(Encoding.UTF8.GetString(input));
                    break;
                case Styles.EncodingStyle.UTF32:
                    sb.Append(Encoding.UTF32.GetString(input));
                    break;
                case Styles.EncodingStyle.Unicode:
                    sb.Append(Encoding.Unicode.GetString(input));
                    break;
                case Styles.EncodingStyle.BigEndianUnicode:
                    sb.Append(Encoding.BigEndianUnicode.GetString(input));
                    break;
            }
            return sb.ToString();
        }

        /// <summary>
        /// Encodes a string into a byte array using a specific encoding style.
        /// </summary>
        /// <param name="input">The data to convert into an array.</param>
        /// <param name="style">The encoding style to use.</param>
        public static byte[] GetBytes(string input, Styles.EncodingStyle style = Styles.EncodingStyle.Default)
        {
            byte[] output = null;
            switch (style)
            {
                case Styles.EncodingStyle.Default:
                    output = Encoding.Default.GetBytes(input);
                    break;
                case Styles.EncodingStyle.ASCII:
                    output = Encoding.ASCII.GetBytes(input);
                    break;
                case Styles.EncodingStyle.UTF7:
                    output = Encoding.UTF7.GetBytes(input);
                    break;
                case Styles.EncodingStyle.UTF8:
                    output = Encoding.UTF8.GetBytes(input);
                    break;
                case Styles.EncodingStyle.UTF32:
                    output = Encoding.UTF32.GetBytes(input);
                    break;
                case Styles.EncodingStyle.Unicode:
                    output = Encoding.Unicode.GetBytes(input);
                    break;
                case Styles.EncodingStyle.BigEndianUnicode:
                    output = Encoding.BigEndianUnicode.GetBytes(input);
                    break;
            }
            return output;
        }

        /// <summary>
        /// Encodes a byte array using a specific encoding style.
        /// </summary>
        /// <param name="input">The array to encode.</param>
        /// <param name="style">The encoding style to use.</param>
        public static byte[] GetBytes(char[] input, Styles.EncodingStyle style = Styles.EncodingStyle.Default)
        {
            byte[] output = null;
            switch (style)
            {
                case Styles.EncodingStyle.Default:
                    output = Encoding.Default.GetBytes(input);
                    break;
                case Styles.EncodingStyle.ASCII:
                    output = Encoding.ASCII.GetBytes(input);
                    break;
                case Styles.EncodingStyle.UTF7:
                    output = Encoding.UTF7.GetBytes(input);
                    break;
                case Styles.EncodingStyle.UTF8:
                    output = Encoding.UTF8.GetBytes(input);
                    break;
                case Styles.EncodingStyle.UTF32:
                    output = Encoding.UTF32.GetBytes(input);
                    break;
                case Styles.EncodingStyle.Unicode:
                    output = Encoding.Unicode.GetBytes(input);
                    break;
                case Styles.EncodingStyle.BigEndianUnicode:
                    output = Encoding.BigEndianUnicode.GetBytes(input);
                    break;
            }
            return output;
        }

        /// <summary>
        /// Converts a string into its Base64 equivalent.
        /// </summary>
        /// <param name="input">The string to convert.</param>
        public static string ToBase64(string input)
        {
            return Convert.ToBase64String(GetBytes(input));
        }

        /// <summary>
        /// Converts a byte array into a Base64 string.
        /// </summary>
        /// <param name="input">The array to convert.</param>
        public static string ToBase64(byte[] input)
        {
            return Convert.ToBase64String(input);
        }

        /// <summary>
        /// Converts a char array into a Base64 string.
        /// </summary>
        /// <param name="input">The array to convert.</param>
        public static string ToBase64(char[] input)
        {
            return Convert.ToBase64String(GetBytes(input));
        }

        /// <summary>
        /// Converts a Base64 string into its plaintext equivalent.
        /// </summary>
        /// <param name="input">The string to decode.</param>
        public static string FromBase64(string input)
        {
            return GetString(Convert.FromBase64String(input));
        }

        #endregion
    }
}
