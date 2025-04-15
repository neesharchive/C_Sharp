using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//Create an abstract class Shape that:

//Has an abstract method Draw()

//Has a virtual method Describe() that prints "I am a shape."

public abstract class Shape
{
    public abstract void Draw();
    public virtual void Describe() {
        Console.WriteLine("I am a Shape");
    }
}

//Create an abstract class Polygon that inherits Shape and:
//    Overrides Describe() to add "I am a polygon."
//    Does not implement Draw() yet
//  Adds a new abstract method GetNumberOfSides()
public abstract class Polygon:Shape
{
    public override void Describe()
    {
        Console.WriteLine("I am a polygon");
    }
    public abstract void GetNumberOfSides();
}


//  Create a class Triangle that:
//  Inherits from Polygon
//  Overrides both Draw() and GetNumberOfSides()
//  Seals the override of Draw()
//  Hides Describe() using new and prints "This is a triangle."

public class Triangle : Polygon
{
    public sealed override void Draw()
    {
        Console.WriteLine("Draw a triangle");
    }
    public override void GetNumberOfSides(){
        Console.WriteLine("3 Sides");
    }
    public new void Describe()
    {
        Console.WriteLine("This is a Triangle");
    }
}

//Create another class EquilateralTriangle that inherits from Triangle and:
//    Attempts to override Draw() — should give a compile-time error (explain why)
//    Tries to call all inherited methods from an EquilateralTriangle object through a Shape reference

public class EquilateralTriangle:Triangle
{
/*    public void override Draw()
    {
        //no longer able to override as there is no base method 'virtual' or abstract to override
        //the previous draw was declared as 'new' so it cannot be overriden. 
    }*/
}
namespace AbstractClass

{
    internal class Program
    {


        static void Main(string[] args)
        {
            Shape s=new EquilateralTriangle();
            s.Draw();
            s.Describe();
            ((Polygon)s).GetNumberOfSides();

            Console.Read();
        }
    }
}
