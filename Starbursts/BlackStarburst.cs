using System;
using TargetPractice.TargetBuilder;

namespace TargetPractice.Starbursts
{
    class BlackStarburst : ObjectTemplate2
    {
        public BlackStarburst()
        {
            _objectType = "Starburst";

            SetPointsValue(300);
            SetObjectColor("BLACK");
            SetObjectSpeed(23); //very fast object
            SetObjectProperties();
        }
    }
}