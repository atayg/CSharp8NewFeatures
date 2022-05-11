using System;

namespace NetCoreTwoDotX._2DefaultInterfaceMethods
{
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}
