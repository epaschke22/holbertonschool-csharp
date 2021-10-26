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
