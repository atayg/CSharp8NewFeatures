using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreThreeDotX._3PatternMatchingEnhancements
{
    public class PropertyPatterns
    {
        //We just check State props because Address class is not our responsibility.
        //Example 1
        public static decimal ComputeSalesTax(Address location, decimal salePrice)
        {
            return location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.075M,
                { State: "MI" } => salePrice * 0.05M,
                _ => 0M
            };
        }

        //Example 2
        static bool IsConferenceDay(DateTime date) => date is { Year: 2020, Month: 5, Day: 19 };

        //Example 3
        /*Console.WriteLine(TakeFive("Hello, world!"));  // output: Hello
          Console.WriteLine(TakeFive("Hi!"));  // output: Hi!
          Console.WriteLine(TakeFive(new[] { '1', '2', '3', '4', '5', '6', '7' }));  // output: 12345
          Console.WriteLine(TakeFive(new[] { 'a', 'b', 'c' }));  // output: abc */

        /*
         static string TakeFive(object input) => input switch
         {
             string { Length: >= 5 } s => s.Substring(0, 5),
             string s => s,

             ICollection<char> { Count: >= 5 } symbols => new string(symbols.Take(5).ToArray()),
             ICollection<char> symbols => new string(symbols.ToArray()),

             null => throw new ArgumentNullException(nameof(input)),
             _ => throw new ArgumentException("Not supported input type."),
         };
        */


        //Example 3: Recursive Property Pattern
       /* public record Point(int X, int Y);
          public record Segment(Point Start, Point End);

        static bool IsAnyEndOnXAxis(Segment segment) =>
            segment is { Start: { Y: 0 } } or { End: { Y: 0 } }; 
       */
    }

    public class Address
    {
        public String State { get; set; }
    }
}
