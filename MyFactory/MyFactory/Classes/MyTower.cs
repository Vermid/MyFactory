using System.Text;

namespace MyFactory
{
    public class MyTower : Calculate
    {
        public MyTower(int wantedNumber, string name)
        {
            numberToCalculate = wantedNumber;
            objectName = name;
        }

        public override string Calculator()
        {
            int maxTower = 9;
            int startTower = 2;
            StringBuilder myStrings = new StringBuilder();

            myStrings.AppendLine("Start Number: " + numberToCalculate.ToString());
            int result = numberToCalculate;

            //Count up from 2
            for (int i = startTower; i <= maxTower; i++)
            {
                myStrings.AppendLine($"{result} * {i} = {result *= i}");
            }
            //Count down from MaxTower
            for (int i = maxTower; i >= startTower; i--)
            {
                myStrings.AppendLine($"{result} / {i} = {result /= i}");
            }

            return myStrings.ToString();
        }
    }
}
