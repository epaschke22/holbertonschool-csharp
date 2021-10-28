using System;

///<summary>Player class</summary>
public class Player
{
    string name;
    float maxHp;
    float hp;

    ///<summary>Player Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.hp = maxHp;
    }
    ///<summary>Print Player health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>Delegate to manage hp change</summary>
    public delegate void CalculateHealth(float value);

    ///<summary>Method for CalculateHealth delegate</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    ///<summary>Method for CalculateHealth delegate</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    ///<summary>Method for changing the hp value</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp > maxHp)
            hp = maxHp;
        else if (newHp < 0)
            hp = 0;
        else
            hp = newHp;
    }

    ///<summary>Delegate to manage hp change with a modifyer</summary>
    public delegate float CalculateModifier(float baseValue, Modifier modifier);

    ///<summary>Delegate method for CalculateModifier</summary>
    public void ApplyModifier (float baseValue, Modifier modifier)
    {
        float result = baseValue;
        switch(modifier)
        {
            case Weak:
                result *= .5;
                break;
            case Base:
                break;
            case Strong:
                result *= 1.5;
        }
        return result;
    }
}

enum Modifider {Weak, Base, Strong};
