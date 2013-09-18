using System;
using TargetPractice.TargetBuilder;

namespace TargetPractice.Bubbles
{
    public class BlueBubble : ObjectTemplate1
    {
        public BlueBubble()
        {
            _objectType = "Bubble";
            this.SetObjectProperties();
        }
        //this could be written differently.  I made it really simple for example purposes.
        public override void SetPointsValue()
        {
            _points = 50;
        }
        public override void SetObjectColor()
        {
            _color = "BLUE";
        }

        public override void SetObjectSpeed()
        {
            _speed = GenerateRandom(1, 5);
        }
    }
}