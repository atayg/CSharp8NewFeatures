using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using NetCoreThreeDotX._2DefaultInterfaceMethods;
using System;

namespace NetCoreThreeDotX
{
   
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Feature: ReadOnlyMembers
            //var summary = BenchmarkRunner.Run<BenchmarkReadonlyMembers>();

            Customer customer = new Customer();
            ICustomer customer1 = customer;

            
                

        }
    }
}
