using MockingWithNSubstitute.Interfaces;
using MockingWithNSubstitute.Objects;

namespace MockingWithNSubstitute
{
    public class DoughFactory : IDoughFactory
    {
        public Dough GetDough(int typeOfDough)
        {
            Dough theDough = null;

            if (typeOfDough == 1)
            {
                theDough = new HardDough();
            }
            else if (typeOfDough == 2)
            {
                theDough = new SoftDough();
            }

            return theDough;
        }
    }
}
