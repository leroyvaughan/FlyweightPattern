using System;

namespace TargetPractice.TargetBuilder
{
    public abstract class ObjectTemplate1
    {
        public string _color;
        public string _objectType;
        public int _points;
        public int _speed;

        //must be overridden in derived class
        public abstract void SetPointsValue();
        public abstract void SetObjectColor();
        public abstract void SetObjectSpeed();

        //used to get random number for bubble speed.
        //does not have to be overridden. speed can be hardcoded in subclass
        public virtual int GenerateRandom(int minValue, int maxValue)
        {
            Random randNum = new Random();
            return randNum.Next(minValue, maxValue);
        }

        //can be overridden to add more code for Object Setup
        public virtual void SetObjectProperties()
        {
            SetPointsValue();
            SetObjectColor();
            SetObjectSpeed();

            Console.WriteLine("{0} colored {1} worth {2} points falling at speed {3}.\r\n",
                                _color, _objectType, _points, _speed);
        }
    }
}