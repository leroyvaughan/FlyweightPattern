using System;
using TargetPractice.Bubbles;
using TargetPractice.Starbursts;

namespace TargetPractice.TargetBuilder
{
    public class ObjectDirector
    {
        BubbleFactory BubblesInc = new BubbleFactory();
        StarburstFactory StarburstsInc = new StarburstFactory();

        public ObjectTemplate1 MakeBubble(int bubbleType){
            return BubblesInc.CreateBubble(bubbleType);
        }

        public ObjectTemplate2 MakeStarburst(int starburstType)
        {
            return StarburstsInc.CreateStarburst(starburstType);
        }
    }
}
