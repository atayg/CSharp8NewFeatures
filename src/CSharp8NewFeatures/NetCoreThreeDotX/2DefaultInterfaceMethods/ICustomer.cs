using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreThreeDotX._2DefaultInterfaceMethods
{
    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }
        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }


        // Version 1:
        //public decimal ComputeLoyaltyDiscount()
        //{
        //    DateTime TwoYearsAgo = DateTime.Now.AddYears(-2);
        //    if ((DateJoined < TwoYearsAgo) && (PreviousOrders.Count() > 10))
        //    {
        //        return 0.10m;
        //    }
        //    return 0;
        //}


        // Version 2:
        public static void SetLoyaltyThresholds(TimeSpan ago, int minimumOrders = 10, decimal percentageDiscount = 0.10m)
        {
            length = ago;
            orderCount = minimumOrders;
            discountPercent = percentageDiscount;
        }

        //Please Attention! We can use 'static' keyword and access modifiers 'ie: private' for prop and method after c# 8.0
        private static TimeSpan length = new TimeSpan(365 * 2, 0, 0, 0); // two years
        private static int orderCount = 10;
        private static decimal discountPercent = 0.10m;

        //public decimal ComputeLoyaltyDiscount()
        //{
        //    DateTime start = DateTime.Now - length;

        //    if ((DateJoined < start) && (PreviousOrders.Count() > orderCount))
        //    {
        //        return discountPercent;
        //    }
        //    return 0;
        //}


        //Version 3:
        public decimal ComputeLoyaltyDiscount() => DefaultLoyaltyDiscount(this);
        protected static decimal DefaultLoyaltyDiscount(ICustomer c)
        {
            DateTime start = DateTime.Now - length;

            if ((c.DateJoined < start) && (c.PreviousOrders.Count() > orderCount))
            {
                return discountPercent;
            }
            return 0;
        }

    }
}
