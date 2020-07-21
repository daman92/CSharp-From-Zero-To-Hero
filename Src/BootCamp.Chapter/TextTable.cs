using System;

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
	        //string padded = message.PadLeft(message.Length + padding);
           // padded = padded.PadRight(padded.Length + padding);
            int maxLineLength = LineLength(message);

            HeaderFooter(padding, maxLineLength);
            PadAboveBelow(maxLineLength, padding);
            PadLeftRight(message, padding);
            PadAboveBelow(maxLineLength, padding);
            HeaderFooter(padding, maxLineLength);


            //  Console.WriteLine("|${padded}|);
            //   for (int ctr = 0; ctr < names.Length; ctr++)
            //       Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);



            return "";
        }

        public static void HeaderFooter(int padding, int lineLength)
        {
	        string border = "+";

            border = border.PadRight(lineLength + (padding * 2), '-') + "+";
//	         for (int i = 0; i < LineLength(message); i++)
//	         {
//		        border += "-";
//			 }
//	        
//			 border += "+";
			 Console.WriteLine(border);
        }

        public static void PadAboveBelow (int maxLineLength, int padding)
        {
            int paddedLine = maxLineLength + (padding * 2);
            string boarder = "|".PadRight(paddedLine) + "|";


            //string boarder = "|";
            // for (int i = 0; i < padding; i++)
            // {
            //     Console.WriteLine(boarder.PadRight(paddedWord.Length+1) + boarder);
            // }
        }

        public static void PadLeftRight(string message, int padding)
        {
            string[] messageLines = message.Split(Environment.NewLine);

            for (int i = 0; i < messageLines.Length; i++)
            {
              Console.WriteLine($"|{messageLines[i].PadLeft(padding).PadRight(padding)}|");
            }

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

        public static int LineCount(string message)
        {
            string[] messageLines = message.Split(Environment.NewLine);

            return messageLines.Length;
        }
    }
}
