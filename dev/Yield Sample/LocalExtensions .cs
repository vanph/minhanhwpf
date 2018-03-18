using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yield
{
    public static class LocalExtensions
    {
        public static IEnumerable<string>
            ConvertCollectionToUpperCase(this IEnumerable<string> source)
        {
            foreach (string str in source)
            {
                Console.WriteLine("ToUpper: source {0}", str);
                yield return str.ToUpper();
            }
        }
    }

   public static class LocalExtensionsTest
    {
       public static void Test()
        {
            string[] stringArray = { "abc", "def", "ghi" };

            var q = from str in stringArray.ConvertCollectionToUpperCase()
                select str;

            foreach (string str in q)
                Console.WriteLine("Test: str {0}", str);
        }
    }
}
