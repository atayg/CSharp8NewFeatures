using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreThreeDotX._11NullCoalescingAssignment
{
    public class NullCoalescingAssignment
    {
        public int? A { get; set; } = null;


        //We can use the ??= operator to replace the following code of the form with A ??= 51;
        void Method()
        {
            if (A == null)
            {
                A = 51;
            }

            //int b = A ??= 35;  
        }

    }
}
