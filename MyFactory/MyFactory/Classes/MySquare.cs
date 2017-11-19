
namespace MyFactory
{
    public class MySquare : Calculate
    {
        public MySquare(int lenght, string name)
        {
            numberToCalculate = lenght;
            objectName = name;
        }

        public override string Calculator()
        {
            return (numberToCalculate * numberToCalculate).ToString();
        }
    }
}
