using System;
using TargetPractice.TargetBuilder;

namespace TargetPractice.Bubbles
{
    public class GreenBubble : ObjectTemplate1
    {
        public GreenBubble()
        {
            _objectType = "Bubble";
            this.SetObjectProperties();
        }

        //this could be written differently.  I made it really simple for example purposes.
        public override void SetPointsValue()
        {
            _points = 75;
        }
        public override void SetObjectColor()
        {
            _color = "GREEN";
        }

        public override void SetObjectSpeed()
        {
            _speed = GenerateRandom(6, 10);
        }
    }
}
