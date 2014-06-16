using MockingWithNSubstitute.Interfaces;
using MockingWithNSubstitute.Objects;

namespace MockingWithNSubstitute
{
    public class Bakery : IBakery
    {
        private readonly IDoughFactory _doughFactory;

        public Bakery()
            : this(new DoughFactory()) { }

        public Bakery(IDoughFactory doughFactory)
        {
            _doughFactory = doughFactory;
        }

        public Bread MakeBread(int typeOfDough)
        {
            var theDough = _doughFactory.GetDough(typeOfDough);

            Bread bread = Bake(theDough);

            return bread;
        }

        public Bread Bake(Dough theDough)
        {
            Bread someBread = null;

            if (theDough != null)
            {
                someBread = new Bread
                {
                    Weight = theDough.Water + theDough.Flour,
                    Softness = (theDough.Water/theDough.Yeast) + (theDough.Flour - theDough.Yeast)
                };
            }

            return someBread;
        }
    }
}
