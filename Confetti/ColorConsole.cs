/*
==============================================================================
Copyright © Jason Drawdy (CloneMerge)

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

#endregion
namespace Confetti
{
    public class ColorConsole
    {
        #region Methods

        /// <summary>
        /// Prints a stylized message to the console.
        /// </summary>
        /// <param name="message">The message to be printed.</param>
        /// <param name="timestamp">Include a timestamp in the message.</param>
        /// <param name="line">Styles the entire line of the message.</param>
        /// <param name="style">The style of the message.</param>
        public static void Print(string message, bool timestamp = false, bool line = false, Styles.MessageStyle style = Styles.MessageStyle.None)
        {
            switch (style)
            {
                case Styles.MessageStyle.General:
                    if (line)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.WriteLine("[-]: " + message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("-");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]: ");
                        Console.WriteLine(message);
                    }
                    break;
                case Styles.MessageStyle.Notice:
                    if (line)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.WriteLine("[*]: " + message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("*");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]: ");
                        Console.WriteLine(message);
                    }
                    break;
                case Styles.MessageStyle.Success:
                    if (line)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.WriteLine("[+]: " + message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("+");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]: ");
                        Console.WriteLine(message);
                    }
                    break;
                case Styles.MessageStyle.Warning:
                    if (line)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.WriteLine("[!]: " + message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]: ");
                        Console.WriteLine(message);
                    }
                    break;
                case Styles.MessageStyle.Error:
                    if (line)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.WriteLine("[x]: " + message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (timestamp)
                            Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("x");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]: ");
                        Console.WriteLine(message);
                    }
                    break;
                case Styles.MessageStyle.None:
                    if (timestamp)
                        Console.Write(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(message);
                    break;
            }
        }

        #endregion
    }
}
