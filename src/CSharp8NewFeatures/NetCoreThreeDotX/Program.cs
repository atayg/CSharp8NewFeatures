using NetCoreThreeDotX._10IndicesAndRanges;
using NetCoreThreeDotX._11NullCoalescingAssignment;
using NetCoreTwoDotX._8AsyncronousStreams;
using System;
using System.Threading.Tasks;

namespace NetCoreThreeDotX
{

    internal class Program
    {
        static async Task Main(string[] args)
        {
            // ************* ReadOnlyMembers 
            //var summary = BenchmarkRunner.Run<BenchmarkReadonlyMembers>();

            // ************* DefaultInterfaceMethods Example
            //Customer customer = new Customer();
            //ICustomer customer1 = customer;

            // ************* PatternMatchingEnhancements Example
            //Console.WriteLine(TakeFive("Hello, world!"));


            // ************* Nullable Referance Exception Example
            //Person person = new Person();
            //Console.WriteLine(person.Details.FirstName);

            //Nullable Reference Type Usage Example
            //Person? person = null;

            //if (person.Details != null)
            //{
            //    Console.WriteLine(person.Details.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine("OK!");
            //}


            // **************** AsyncronousStreams Example
            //AsyncronousStreams asyncronousStreams = new AsyncronousStreams();
            //await foreach (var number in asyncronousStreams.GenerateSequence())
            //{
            //    Console.WriteLine(number);
            //}


            // *************** Indices And Ranges Example 
            IndicesAndRanges indicesAndRanges = new IndicesAndRanges();
            //Console.WriteLine($"The last word is {indicesAndRanges.words[^1]}");

            //Range
            //var quickBrownFox = indicesAndRanges.words[1..4];
            //foreach (var item in quickBrownFox)
            //{
            //    Console.WriteLine(item);
            //}

            //var lazyDog = indicesAndRanges.words[^2..^0];
            //foreach (var item in lazyDog)
            //{
            //    Console.WriteLine(item);
            //}

            //var allWords = indicesAndRanges.words[..]; // contains "The" through "dog".
            //var firstPhrase = indicesAndRanges.words[..4]; // contains "The" through "fox"
            //var lastPhrase = indicesAndRanges.words[6..];

            //foreach (var item in allWords)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("***************");

            //foreach (var item in firstPhrase)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("***************");

            //foreach (var item in lastPhrase)
            //{
            //    Console.WriteLine(item);
            //}

            //Range Declaration
            //Range phrase = 1..4;            


            // *************** NullCoalescingAssignment Example
            NullCoalescingAssignment nullCoalescingAssignment = new NullCoalescingAssignment();
            int b = nullCoalescingAssignment.A ?? -1;
            Console.WriteLine(b);

        }
    }
}
