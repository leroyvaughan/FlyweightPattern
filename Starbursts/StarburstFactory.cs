using System;
using TargetPractice.TargetBuilder;
using TargetPractice.Starbursts;

namespace TargetPractice.Starbursts
{
    public abstract class StarburstFactoryBase
    {
        public abstract ObjectTemplate2 CreateStarburst(int type);
    }

    public class StarburstFactory : StarburstFactoryBase
    {
        public override ObjectTemplate2 CreateStarburst(int type)
        {
            switch (type)
            {
                case 1: return new BlackStarburst();
                case 2: return new YellowStarburst();
                default: return new YellowStarburst();
            }
        }
    }
}