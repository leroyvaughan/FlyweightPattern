using System;
using TargetPractice.TargetBuilder;

namespace TargetPractice.FlyweightObject
{
    //abstract class: must be derived from as a base class
    public abstract class FlyingObjectTemplate
    {
        public string Color { get; set; }
        public int Points { get; set; }
        public int Speed { get; set; }
        public string ObjectType { get; set; }


        public void SetObjectProperties()
        {
            Console.WriteLine("\r\nFlying Object created:\r\n");
            Console.WriteLine("Type: {0}", ObjectType);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Points: {0}", Points);
            Console.WriteLine();
        }
    }

    public class OnTheFlyObject : FlyingObjectTemplate
    {
        public OnTheFlyObject(string type, int points, string color, int speed)
        {
            this.ObjectType = type;
            this.Points = points;
            this.Color = color;
            this.Speed = speed;
            this.SetObjectProperties();
        }
    }
}
