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

///<summary>test object to inherit everything</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>interface 1 method</summary>
    public void Interact()
    {
        throw new NotImplementedException();
    }
    ///<summary>interface 2 variable</summary>
    public int durability { get; set; }
    ///<summary>interface 2 method</summary>
    public void Break()
    {
        throw new NotImplementedException();
    }
    ///<summary>interface 3 variable</summary>
    public bool isCollected { get; set; }
    ///<summary>interface 3 method</summary>
    public void Collect()
    {
        throw new NotImplementedException();
    }
}
