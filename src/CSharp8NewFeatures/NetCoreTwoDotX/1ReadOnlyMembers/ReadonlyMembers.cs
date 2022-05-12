namespace NetCoreTwoDotX._1ReadOnlyMembers
{
    public struct ReadonlyMembers
    {
        public int Number { get; set; }

        public int Square()
        {
            return Number * Number;
        }
    }
}
