using System;

namespace NetCoreTwoDotX._3PatternMatchingEnhancements
{
    public class PropertyPatterns
    {
        //public static decimal ComputeSalesTax(Address location, decimal salePrice)
        //{
        //    return location switch
        //    {
        //        { State: "WA" } => salePrice * 0.06M,
        //        { State: "MN" } => salePrice * 0.075M,
        //        { State: "MI" } => salePrice * 0.05M,
        //        _ => 0M
        //    };
        //}
    }
    public class Address
    {
        public String State { get; set; }
    }
}
