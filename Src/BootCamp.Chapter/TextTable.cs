using System;
using System.Collections.Concurrent;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        /*

         Input: "Hello", 0
           +-----+
           |Hello|
           +-----+
           
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
           
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+

         */

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
        {
	        int maxLineLength = LineLength(message);

            string head = HeaderFooter(padding, maxLineLength);
            string above = PadAboveBelow(maxLineLength, padding);
            string newMessage = PadLeftRight(message, padding);
            string below = PadAboveBelow(maxLineLength, padding);
            string footer = HeaderFooter(padding, maxLineLength);

            return $"{head}{above}{newMessage}{below}{footer}";
        }

        public static string HeaderFooter(int padding, int lineLength)
        {
	        string border = "+";

            border = border.PadRight(lineLength + (padding * 2), '-') + "+" + Environment.NewLine;

	        return border;
        }

        public static string PadAboveBelow (int maxLineLength, int padding)
        {
            int paddedLine = maxLineLength + (padding * 2);
            string boarder = "|".PadRight(paddedLine) + "|" + Environment.NewLine;
            
            return boarder;
        }

        public static string PadLeftRight(string message, int padding)
        {
	        int messageLength = LineLength(message);
	        string[] messageLines = message.Split(Environment.NewLine);
	        string sendback = "";
            for (int i = 0; i < messageLines.Length; i++)
            {
	            string buffer = "".PadRight(padding);
	            string bufferedMessage = messageLines[i].PadRight(messageLength);

	            sendback += $"|{buffer}{bufferedMessage}|" + Environment.NewLine;
            }

            return sendback;
        }

        public static int LineLength(string message)
        {
	        string[] messageLines = message.Split(Environment.NewLine);

	        int maxLength = 0;

	        for (int i = 0; i < messageLines.Length; i++)
	        {
		        if (messageLines[i].Length > maxLength)
		        {
			        maxLength = messageLines[i].Length;
		        }
	        }
	        
	        return maxLength;
        }
    }
}
