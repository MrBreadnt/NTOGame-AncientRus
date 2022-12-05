using System;

public abstract class Entity
{   
    public abstract int Hp
    {
        get;
        set;
    }

    public void IncreaseHp(int hp)
    {
        Hp += hp;
        OnHpChanged(Hp);
    }

    public void DecreaseHp(int hp)
    {
        Hp -= hp;
        OnHpChanged(Hp);
    }

    public abstract void OnHpChanged(int newHp);

    public abstract int Mana
    {
        get;
        set;
    }

    public void IncreaseMana(int mana)
    {
        Mana += mana;
        OnManaChanged(Mana);
    }

    public void DecreaseMana(int mana)
    {
        Mana -= mana;
        OnManaChanged(Mana);
    }

    public abstract void OnManaChanged(int newMana);

    public Item LeftHand
    {
        get;
        set;
    }

    public Item RightHand
    {
        get;
        set;
    }
}
