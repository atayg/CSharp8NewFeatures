using System;

namespace NetCoreThreeDotX._6DisposableRefStructs
{
    public partial class UsingNotification
    {
        public class DisposableRefStructs
        {
            void Method()
            {
                using var book = new Book();

            }

            //ref struct Example usage: Span<T>
            ref struct Book 
            {
                public void Dispose()
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}
