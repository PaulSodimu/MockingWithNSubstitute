﻿using MockingWithNSubstitute.Objects;

namespace MockingWithNSubstitute.Interfaces
{
    public interface IBakery
    {
        Bread MakeBread(int typeOfDough);

        Bread Bake(Dough theDough);
    }
}
