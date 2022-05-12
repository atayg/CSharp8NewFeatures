using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreTwoDotX._14EnhancementOfInterpolatedVerbatimStrings
{
    public class EnhancementOfInterpolatedVerbatimStrings
    {
        void Method()
        {
            int Base = 40;
            int Height = 80;
            int area = (Base * Height) / 2; //Triangle area

            string variablesAsStr = $@"Height = ""{Height}"" and Base = ""{Base}""";
            //string areaAsStr = @$"Area = ""{area}"""; //will not work
        }
    }
}
