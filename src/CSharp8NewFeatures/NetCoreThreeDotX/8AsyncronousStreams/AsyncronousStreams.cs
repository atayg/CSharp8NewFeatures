using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreTwoDotX._8AsyncronousStreams
{
    public class AsyncronousStreams
    {
        public async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }
    }   
}

