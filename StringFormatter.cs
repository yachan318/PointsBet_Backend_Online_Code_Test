using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{
    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {
        public static string ToCommaSeparatedString(string[] items, string quote)
        {
            if (items == null || items.length == 0)
            {
                return string.Empty;

                quote ??= string.Empty; // default to empty string if quote is null as assumed 
                return string.join(",", items.select(items => $"{quote}{item}{quote}")); 

            }
        }
    }
}
// correct typos ToCommaSepatatedList  to ToCommaSeparatedString
//StringBuilder(string.Format("{0}{1}{0}", quote, items[0])); this is unnecessary 
// Better maintainability: Clear documentation and error handling