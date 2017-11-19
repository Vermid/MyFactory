using static MyFactory.MyEnums;

namespace MyFactory
{
    public class MyFactory
    {
        //this is a simple Factory to Create objects 
        /// <summary>
        /// Create Different types of objects based on the objectType. Returns the Object of its created else NULL
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public ICalculate CreateObjects(int number, string name, CalculatorEnums objectType)
        {
            switch (objectType)
            {
                case CalculatorEnums.Tower:
                    MyTower tower = new MyTower(number, name);
                    return tower ?? null;
                case CalculatorEnums.Circle:
                    MyCirlce circle = new MyCirlce(number, name);
                    return circle ?? null;
                case CalculatorEnums.Square:
                    MySquare square = new MySquare(number, name);
                    return square ?? null;
            }
            return null;
        }
    }
}
