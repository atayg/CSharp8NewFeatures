using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreTwoDotX._13StackallocInNestedExpressions
{
    public class StackallocInNestedExpressions
    {
        void Method()
        {
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            //int ind = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 }); //nested usage of stackalloc will not working in c# 7.3
        }
    }
}
