using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace LinqUsingEnumerable
{
    internal class VeryComplexQueryExpression
    {
        public static void QueryStringsWithRawDelegates()
        {
            Console.WriteLine("***** Using Raw Delegates *****");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            // Build the necessary Func<> delegates.
            Func<string, bool> searchFilter = new Func<string, bool>(Filter);
            Func<string, string> itemToProcess = new Func<string, string>(ProcessItem);

            var subset = currentVideoGames
                .Where(searchFilter)
                .OrderBy(itemToProcess)
                .Select(itemToProcess);

            foreach(var game in subset)
            {
                Console.WriteLine("Item: " + game);
            }
            Console.WriteLine();

        }

        public static bool Filter(string filter) {

            return filter.Contains(" ");
            
            
        }
        public static string ProcessItem(string item) {

            return item;
        }

    }
}
