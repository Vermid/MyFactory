using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactory
{
    public interface ICalculate
    {
        //calculate the wanted object
        string Calculator();
        //write the Result into a .txt
        void WriteFile(string result);
    }
}
