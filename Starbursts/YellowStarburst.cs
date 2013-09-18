using System;
using TargetPractice.TargetBuilder;

namespace TargetPractice.Starbursts
{
    class YellowStarburst : ObjectTemplate2
    {
        public YellowStarburst()
        {
            _objectType = "Starburst";

            SetPointsValue(200);
            SetObjectColor("YELLOW");
            SetObjectSpeed(20); //very fast object
            SetObjectProperties();
        }
    }
}