using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreThreeDotX._2DefaultInterfaceMethods
{
    public class Customer : ICustomer
    {
        public IEnumerable<IOrder> PreviousOrders => throw new NotImplementedException();

        public DateTime DateJoined => throw new NotImplementedException();

        public DateTime? LastOrder => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public IDictionary<DateTime, string> Reminders => throw new NotImplementedException();

        //public decimal ComputeLoyaltyDiscount()
        //{
        //    if (PreviousOrders.Any() == false)
        //        return 0.50m;
        //    else
        //        return ICustomer.DefaultLoyaltyDiscount(this);
        //}

    }
}
