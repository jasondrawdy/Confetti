<p align="center">
    <img width="256" height="256" src="https://user-images.githubusercontent.com/40871836/43488412-47349f72-94df-11e8-9b1c-bb5f1ac1870d.png">
</p>

# Confetti
<p align="left">
    <!-- Version -->
    <img src="https://img.shields.io/badge/version-1.0.0-brightgreen.svg">
    <!-- Docs -->
    <img src="https://img.shields.io/badge/docs-not%20found-lightgrey.svg">
    <!-- License -->
    <img src="https://img.shields.io/badge/license-MIT-blue.svg">
</p>

A simple console stylizing library for .NET applications which boasts various styles and allows the coloration of individual components of the console itself. Messages can be printed with or without color as well as other settings such as timestamps and entire line formatting. The library also comes with some baseline extension methods such as converting strings to byte arrays, byte arrays to strings, and Base64 conversions for char arrays, strings, and byte arrays.

### Requirements
- .NET Framework 4.6.1

# Features
- Stylize the default console using multiple style types
    - **General** *(Grey)*
    - **Notice** *(Cyan)*
    - **Success** *(Green)*
    - **Warning** *(Yellow)*
    - **Error** *(Red)*
    - **None** *(No formatting)*
- Encoding output using different encoding styles
    - **Default**
    - **ASCII**
    - **UTF7**
    - **UTF8**
    - **UTF32**
    - **Unicode**
    - **BigEndianUnicode**
- Colorize the entire line of console output
- Provide timestamps with console output

# Examples
This example shows how to stylize the console using Confetti and some its features such has full row colorization, timestamping, and some of the general use cases for the provided extension methods.

```c#
using System;
using Confetti;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Print to console using a timestamp.
            ColorConsole.Print("This message has a timestamp!", true, false, Styles.MessageStyle.Notice);

            // Print to console using a timestamp and color the entire line.
            ColorConsole.Print("This message has a timestamp and the entire line is colored!\n", true, true, Styles.MessageStyle.Notice);

            // Print to the console using various styles while coloring the entire line.
            ColorConsole.Print("[-] This message has no formatting.", false, true, Styles.MessageStyle.None);
            ColorConsole.Print("[-] This is a General message with line coloring.", false, true, Styles.MessageStyle.General);
            ColorConsole.Print("[=] This is a Notice message with line coloring.", false, true, Styles.MessageStyle.Notice);
            ColorConsole.Print("[+] This is a Success message with line coloring.", false, true, Styles.MessageStyle.Success);
            ColorConsole.Print("[!] This is a Warning message with line coloring.", false, true, Styles.MessageStyle.Warning);
            ColorConsole.Print("[x] This is a Error message with line coloring.\n", false, true, Styles.MessageStyle.Error);

            // Print to the console using various styles.
            ColorConsole.Print("[-] This message has no formatting.", false, false, Styles.MessageStyle.None);
            ColorConsole.Print("[-] This is a General message.", false, false, Styles.MessageStyle.General);
            ColorConsole.Print("[=] This is a Notice message.", false, false, Styles.MessageStyle.Notice);
            ColorConsole.Print("[+] This is a Success message.", false, false, Styles.MessageStyle.Success);
            ColorConsole.Print("[!] This is a Warning message.", false, false, Styles.MessageStyle.Warning);
            ColorConsole.Print("[x] This is a Error message.\n", false, false, Styles.MessageStyle.Error);

            // Some basic conversions using the utils class.
            var message = "Hello, World!";

            // Encode our string as a Base64 string.
            var base64String = Utils.ToBase64(message);

            // Get the bytes of the string using various encoding styles.
            var encodedBytes = Utils.GetBytes(base64String, Styles.EncodingStyle.BigEndianUnicode);

            // Get the string of our encoded bytes and print it to the console.
            var decodedBytes = Utils.GetString(encodedBytes);
            ColorConsole.Print(decodedBytes, true, true, Styles.MessageStyle.Success);

            // Wait for user interaction.
            Console.Read();
        }
    }
}
```

# Credits
**Icon:** `Pixel Buddha`
<br>https://www.flaticon.com/authors/pixel-buddha

# License

Copyright © ∞ Jason Drawdy 

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
