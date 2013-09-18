using System;
using TargetPractice.Bubbles;
using TargetPractice.FlyweightObject;
using TargetPractice.TargetBuilder;

namespace TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets make some Targets!\r\n");

            //TEMPLATE METHOD DESIGN PATTERN
            Console.WriteLine("These will be made using the Template Method");
            Console.WriteLine("----------------------------------------\r\n");
            RedBubble RedBubble = new RedBubble();
            GreenBubble GreenBubble = new GreenBubble();
            BlueBubble BlueBubble = new BlueBubble();

            //FACTORY METHOD DESIGN PATTERN
            Console.WriteLine("\r\n\r\nThen using the Factory Method!");
            Console.WriteLine("----------------------------------------\r\n");
            BubbleFactory BubblesInc = new BubbleFactory();
            BubblesInc.CreateBubble(1);      //red
            BubblesInc.CreateBubble(2);      //green
            BubblesInc.CreateBubble(3);      //blue

            //BUILDER DESIGN PATTERN
            Console.WriteLine("\r\n\r\nNext let's use the Builder Design Pattern!");
            Console.WriteLine("----------------------------------------\r\n");
            ObjectDirector ObjDirector = new ObjectDirector();
            ObjDirector.MakeBubble(1);      //red
            ObjDirector.MakeBubble(2);      //green
            ObjDirector.MakeBubble(3);      //blue

            ObjDirector.MakeStarburst(1);   //black
            ObjDirector.MakeStarburst(2);   //yellow


            //FLYWEIGHT DESIGN PATTERN USAGE
            Console.WriteLine("\r\n\r\nNow let's use the Flyweight Design Pattern!");
            Console.WriteLine("----------------------------------------\n");
            FlyweightFactory FlyWeightObjects = new FlyweightFactory();

            //They are Flyweight objects obviously, but are Flying Objects in the project
            FlyWeightObjects.MakeFlyingObject();    //make generic blue bubble
            FlyWeightObjects.MakeFlyingObject("Starburst"); //make starburst
            FlyWeightObjects.MakeFlyingObject("Bird");    //make bird

            //make new shared object on the fly
            FlyWeightObjects.MakeFlyingObject("Balloon", 25, "red", 5);

            //use shared flyweight objects created above in the same order
            FlyWeightObjects.MakeFlyingObject();    //this will be the default Blue Bubble
            FlyWeightObjects.MakeFlyingObject("Starburst");
            FlyWeightObjects.MakeFlyingObject("Bird");
            FlyWeightObjects.MakeFlyingObject("Balloon");

            Console.ReadKey();
        }
    }
}