using System;

namespace NetCoreTwoDotX._5StaticLocalFunctions
{
    public class StaticLocalFunctions
    {
        int z = 0;
        int Method()
        {
            int y = 0;
            LocalFunction();
            return y;

            void LocalFunction() => z = 0;
        }

        int Method2()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);

            int Add(int left, int right) => left + right;
            //static int Add(int left, int right) => left + right;
        }
    }
}
