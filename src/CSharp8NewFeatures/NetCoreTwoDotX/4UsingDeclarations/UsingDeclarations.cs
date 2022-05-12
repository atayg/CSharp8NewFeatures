using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreTwoDotX._4UsingDeclarations
{
    public class UsingDeclarations
    {
        static int WriteLinesToFile(IEnumerable<string> lines)
        {
            using (var file = new System.IO.StreamWriter("WriteLines2.txt"))
            {
                int skippedLines = 0;
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                    else
                    {
                        skippedLines++;
                    }
                }
                // Notice how skippedLines is in scope here.
                return skippedLines;
            }   // file is disposed here
        }
    }
}
