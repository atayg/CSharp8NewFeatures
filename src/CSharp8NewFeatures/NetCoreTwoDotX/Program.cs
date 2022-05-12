using NetCoreTwoDotX._10IndexesAndRanges;
using NetCoreTwoDotX._7NullableReferenceTypes;
using System;

namespace NetCoreTwoDotX
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nullable Referance Exception Example
            //Person person = new Person();
            //Console.WriteLine(person.Details.FirstName);

            //Nullable Reference Type Usage Example
            //Person? person = null;
            //Person person = null;

            //if (person.Details != null)
            //{
            //    Console.WriteLine(person.Details.FirstName);
            //}
            //else
            //{
            //    Console.WriteLine("OK!");
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

        }
    }
}
