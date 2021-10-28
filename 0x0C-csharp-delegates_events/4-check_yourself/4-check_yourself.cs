using System;

///<summary>Player class</summary>
public class Player
{
    string name;
    float maxHp;
    float hp;
    string status;

    ///<summary>Player Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
        status = String.Format($"{name} is ready to go!");
        HPCheck += CheckStatus;
    }
    ///<summary>Print Player health</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

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
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    ///<summary>Delegate method for CalculateModifier</summary>
    public float ApplyModifier (float baseValue, Modifier modifier)
    {
        float result = baseValue;
        switch(modifier)
        {
            default:
                break;
            case Modifier.Weak:
                result *= .5f;
                break;
            case Modifier.Strong:
                result *= 1.5f;
                break;
        }
        return result;
    }

    ///<summary>event handler called HPcheck that holds currenthpargs classes</summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    ///<summary>prints a message based on passed in currentHPargs class currenthp value</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            Console.WriteLine($"{name} is in perfect health!");
        else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
            Console.WriteLine($"{name} is doing well!");
        else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
            Console.WriteLine($"{name} isn't doing too great...");
        else if (e.currentHp > 0 && e.currentHp < maxHp / 4)
            Console.WriteLine($"{name} needs help!");
        else
            Console.WriteLine($"{name} is knocked out!");
    }
}

///<summary>Delegate to manage hp change</summary>
public delegate void CalculateHealth(float value);

///<summary>Delegate to manage hp change with a modifyer</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
///<summary>Enum for different kinds of modifiers</summary>
public enum Modifier {
    ///<summary>50% damage</summary>
    Weak,
    ///<summary>100% damage</summary>
    Base,
    ///<summary>150% damage</summary>
    Strong
};

///<summary>gets current hp and sets new hp values</summary>
public class CurrentHPArgs : EventArgs
{
    ///<summary>variable to hold current hp when given value on class creation</summary>
    public readonly float currentHp;

    ///<summary>construtor of currentHPargs class</summary>
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}
