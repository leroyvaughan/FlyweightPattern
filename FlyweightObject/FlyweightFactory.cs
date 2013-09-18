using System;
using System.Collections.Generic;
using TargetPractice.TargetBuilder;


namespace TargetPractice.FlyweightObject
{
    //abstract class...cannot be created; must be derived from as a base class
    public abstract class FlyweightFactoryBase
    {
        public abstract OnTheFlyObject MakeFlyingObject(string key = "Bubble", 
                                                    int points = 150,
                                                    string color = "Blue",
                                                    int speed = 12);
    }


    public class FlyweightFactory : FlyweightFactoryBase
    {
        //Object Dictionary to store the Flywieght objects
        private Dictionary<string, OnTheFlyObject> _flyweights = new Dictionary<string, OnTheFlyObject>();

        //the default object created will be a blue bubble when no params are passed
        public override OnTheFlyObject MakeFlyingObject(string key = "Bubble", 
                                                    int points = 150, 
                                                    string color = "Blue",
                                                    int speed = 12)
        {
            string objectKey = key.ToLower();

            //if the object is already in the Dictionary, re-use it
            if (_flyweights.ContainsKey(objectKey))
            {
                OnTheFlyObject curObj = _flyweights[objectKey];
                Console.WriteLine("\r\n#######Re-using Shared Flyweight Object ###########\r\n");
                Console.WriteLine("Type: {0}", curObj.ObjectType);
                Console.WriteLine("Color: {0}", curObj.Color);
                Console.WriteLine("Speed: {0}", curObj.Speed);
                Console.WriteLine("Points: {0}", curObj.Points);
                Console.WriteLine();

                return curObj;
            }
            else
            {
                //else, Factory should create a new Object
                OnTheFlyObject returnObject;

                /*
                 * it's really simple right now, but could be modified to create all of the types
                 * of possible objects/targets: bubbles, yellow starbursts, and even enemy starships.
                */
                switch (objectKey)
                {
                    case "starburst":
                        returnObject = new OnTheFlyObject("Starburst", 300, "Black", 20);
                        break;

                    case "bird":
                        returnObject = new OnTheFlyObject("Bird", 50, "Brown", 30);
                        break;

                    /*
                     * The factory will also create ANY object using passed parameters 
                     * ...or will simply create a Blue Bubble since those are default values
                    */
                    default:
                        returnObject = new OnTheFlyObject(key, points, color, speed);
                        break;
                }

                //add to Dictionary before returning object
                _flyweights.Add(objectKey, returnObject);
                return returnObject;
            }
        }
    }
}