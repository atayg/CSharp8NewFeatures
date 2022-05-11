using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreTwoDotX._2DefaultInterfaceMethods
{
    public class Customer : ICustomer
    {
        public IEnumerable<IOrder> PreviousOrders => throw new NotImplementedException();

        public DateTime DateJoined => throw new NotImplementedException();

        public DateTime? LastOrder => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public IDictionary<DateTime, string> Reminders => throw new NotImplementedException();

    }
}
