using DZ_10_13;
using System;

public class BuildingsCollection
{
    private Building[] buildings = new Building[10];

    public Building this[int index]
    {
        get
        {
            return buildings[index];
        }
        set
        {
            buildings[index] = value;
        }
    }
}
