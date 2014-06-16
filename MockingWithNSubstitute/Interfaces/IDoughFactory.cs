using MockingWithNSubstitute.Objects;

namespace MockingWithNSubstitute.Interfaces
{
    public interface IDoughFactory
    {
        Dough GetDough(int typeOfDough);
    }
}
