using System.Collections.Generic;
using static MyFactory.MyEnums;

namespace MyFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICalculate> CalculateList = new List<ICalculate>();
            MyFactory factory = new MyFactory();

            CalculateList.Add(factory.CreateObjects(12, "Tower1", CalculatorEnums.Tower));
            CalculateList.Add(factory.CreateObjects(27, "Tower2", CalculatorEnums.Tower));
            CalculateList.Add(factory.CreateObjects(5, "Tower3", CalculatorEnums.Tower));

            CalculateList.Add(factory.CreateObjects(20, "Circle1", CalculatorEnums.Circle));
            CalculateList.Add(factory.CreateObjects(312, "Circle2", CalculatorEnums.Circle));

            CalculateList.Add(factory.CreateObjects(10, "Square1", CalculatorEnums.Square));
            CalculateList.Add(factory.CreateObjects(200, "Square2", CalculatorEnums.Square));
            CalculateList.Add(factory.CreateObjects(5, "Square3", CalculatorEnums.Square));

            foreach (Calculate item in CalculateList)
            {
                if (item is MyCirlce)
                {
                    string text = $"The Radius is {item.numberToCalculate} and the Area of the Cirle is {item.Calculator()}";
                    item.WriteFile(text);
                }
                if (item is MySquare)
                {
                    string text = $"The Lenght is {item.numberToCalculate} and the Area of the Square is {item.Calculator()}";
                    item.WriteFile(text);
                }
                if (item is MyTower)
                {
                    item.WriteFile(item.Calculator());
                }
            }
        }
    }
}
