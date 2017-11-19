using System;

namespace MyFactory
{
    public class MyCirlce : Calculate
    {
        public MyCirlce(int radius, string name)
        {
            numberToCalculate = radius;
            objectName = name;
        }

        public override string Calculator()
        {
            return (numberToCalculate * numberToCalculate * Math.PI).ToString();
        }
    }
}
