using System;
using TargetPractice.TargetBuilder;

namespace TargetPractice.Bubbles
{
    public abstract class BubbleFactoryBase
    {
        public abstract ObjectTemplate1 CreateBubble(int type);
    }

    public class BubbleFactory : BubbleFactoryBase
    {
        public override ObjectTemplate1 CreateBubble(int type)
        {
            switch (type)
            {
                case 1: return new RedBubble();
                case 2: return new GreenBubble();
                case 3: return new BlueBubble();
                default: return new RedBubble();
            }
        }
    }
}