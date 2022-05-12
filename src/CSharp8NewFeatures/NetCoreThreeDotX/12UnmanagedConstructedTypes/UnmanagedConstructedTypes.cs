using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreThreeDotX._12UnmanagedConstructedTypes
{
    public ref struct UnmanagedConstructedTypes
    {
        public struct Coords<T>
        {
            public T X;
            public T Y;
        }

        //Span<Coords<int>> coordinates = stackalloc[]
        //{
        //    new Coords<int> { X = 0, Y = 0 },
        //    new Coords<int> { X = 0, Y = 3 },
        //    new Coords<int> { X = 4, Y = 0 }
        //};
    }
}
