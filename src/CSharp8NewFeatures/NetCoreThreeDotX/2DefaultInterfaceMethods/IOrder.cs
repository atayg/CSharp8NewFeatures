using System;

namespace NetCoreThreeDotX._2DefaultInterfaceMethods
{
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}
