using System;
using TargetPractice.TargetBuilder;

namespace TargetPractice.Bubbles
{
    public class RedBubble : ObjectTemplate1
    {
        public RedBubble()
        {
            _objectType = "Bubble";
            this.SetObjectProperties();
        }


        //this could be written differently.  I made it really simple for example purposes.
        public override void SetPointsValue()
        {
            _points = 150;
        }
        public override void SetObjectColor()
        {
            _color = "RED";
        }

        public override void SetObjectSpeed()
        {
            _speed = GenerateRandom(10, 15);
        }
    }
}