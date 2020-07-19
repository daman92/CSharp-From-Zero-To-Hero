using System;
using System.Collections.Immutable;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

	        TextTable.Build($"Hello{Environment.NewLine}World!", 0);
	        // Print each of the statistical output using Text Table with padding 3:
	        // - FindHighestBalanceEver
	        // - FindPersonWithBiggestLoss
	        // - FindRichestPerson
	        // - FindMostPoorPerson
        }
    }
}
