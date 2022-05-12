using System;

namespace NetCoreTwoDotX._6DisposableRefStructs
{
    public class DisposableRefStructs
    {
        struct Book: IDisposable
        {
            public void Dispose()
            {
                
            }
        }
               
        //Example usage: Span<T>
        //ref struct Book2 : IDisposable
        //{
        //    public void Dispose()
        //    {
        //    }
        //}
    }
}
