using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player : Entity
{
    [SerializeField]
    public int hp;

    [SerializeField]
    public int mana;

    [SerializeField]
    public Item leftHand;
    [SerializeField]
    public Item rightHand;

    public override int Hp
    {
        get {return hp;}
        set {hp = value;}
    }

    public override int Mana
    {
        get {return mana;}
        set {mana = value;}
    }

    public override void OnHpChanged(int newHp)
    {

    }

    public override void OnManaChanged(int newMana)
    {

    }
}
