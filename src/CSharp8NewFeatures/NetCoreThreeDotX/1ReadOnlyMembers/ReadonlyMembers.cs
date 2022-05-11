using BenchmarkDotNet.Attributes;

namespace NetCoreThreeDotX
{
    public struct ReadonlyMembers
    {
        public int Number { get; set; }

        public ReadonlyMembers(int number)
        {
            Number = number;
        }

        public readonly int Square()
        {
            return Number * Number;
        }

    }

    [MemoryDiagnoser]
    public class BenchmarkReadonlyMembers
    {
        [Benchmark]
        public int SquareValue()
        {
            var readOnkyMembers = new ReadonlyMembers(50000);
            return readOnkyMembers.Square();
        }
    }
}
