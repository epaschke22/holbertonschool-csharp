using System;

///<summary>abstract class</summary>
public abstract class Base
{
    ///<summary>abstract class variable</summary>
    public string name { get; set; }
    ///<summary>abstract class method overrid</summary>
    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType());
    }
}

///<summary>interface 1</summary>
interface IInteractive
{
    void Interact();
}

///<summary>interface 2</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary>interface 3</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

///<summary>Door Class</summary>
public class Door : Base, IInteractive
{
    ///<summary>constructor</summary>
    public Door(string Name = "Door")
    {
        name = Name;
    }
    ///<summary>interface 1 method</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

///<summary>Decoration Class</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>quest item toggle</summary>
    public bool isQuestItem;
    ///<summary>durability rating</summary>
    public int durability { get; set; }

    ///<summary>constructor</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary>IInteractive method</summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    ///<summary>IBreakable method</summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
