using System;

namespace MockingWithNSubstitute.Objects
{
    public class Bread
    {
        public int Weight { get; set; }
        public int Softness { get; set; }

        public override string ToString()
        {
            return 
                "Weight: " + Weight + Environment.NewLine + 
                    "Softness: " + Softness;
        }
    }
}
