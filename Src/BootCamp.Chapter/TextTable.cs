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
	        string padded = message.PadLeft(message.Length + padding);
            padded = padded.PadRight(padded.Length + padding);
            

            Header(padded);
            PadAboveBelow(padded, padding);
            Console.WriteLine($"|{padded}|");
            PadAboveBelow(padded, padding);
            Header(padded);


            //  Console.WriteLine("|${padded}|);
            //   for (int ctr = 0; ctr < names.Length; ctr++)
            //       Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);



            return "";
        }

        public static void Header(string message)
        {
	        string border = "+";
            
	        
	         for (int i = 0; i < LineLength(message); i++)
	         {
		        border += "-";
			 }
	        
			 border += "+";
			 Console.WriteLine(border);
        }

        public static void PadAboveBelow (string paddedWord, int padding)
        { 
	        
	        
	        
	        //string boarder = "|";
	       // for (int i = 0; i < padding; i++)
	       // {
		   //     Console.WriteLine(boarder.PadRight(paddedWord.Length+1) + boarder);
	       // }
        }

        public static int LineLength(string message)
        {
	        string[] messageLines = message.Split(Environment.NewLine);

	        int maxLength = 0;

	        for (int i = 0; i < messageLines.Length - 1; i++)
	        {
		        if (messageLines[i].Length > maxLength)
		        {
			        maxLength = messageLines.Length;
		        }
	        }
	        
	        return maxLength;
        }
    }
}
