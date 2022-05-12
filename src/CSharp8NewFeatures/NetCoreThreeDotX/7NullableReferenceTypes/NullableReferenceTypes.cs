using System;
using System.Collections.Generic;

namespace NetCoreThreeDotX._7NullableReferenceTypes
{
    public class NullableReferenceTypes
    {
        public class Person
        {
            public Details? Details { get; set; }   
        }

        public class Details
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
        }
    }
}
