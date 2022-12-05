using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Weapon : Item
{
    public int Damage
    {
        get;
        set;
    }

    public int Cooldown
    {
        get;
        set;
    }

    public int Range
    {
        get;
        set;
    } 
}
