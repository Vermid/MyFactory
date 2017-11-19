using System;
using System.IO;

namespace MyFactory
{
    public abstract class Calculate : ICalculate
    {
        public string objectName;
        public int numberToCalculate;

        /// <summary>
        /// Return the Result as string 
        /// </summary>
        /// <returns></returns>
        public virtual string Calculator()
        {
            return null;
        }

        /// <summary>
        /// Saves the Result into a specific Directory with the given name as .txt
        /// </summary>
        /// <param name="result"></param>
        public void WriteFile(string result)
        {
            string path = $"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop) }\\{objectName}.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllText(path, result);
        }
    }
}
