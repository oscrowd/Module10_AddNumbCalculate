using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_AddNumbCalculate
{
    internal class Program
    {
        static Ilogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var worker1 = new Worker1(Logger);
            var worker2 = new Worker2(Logger);
            var worker3 = new Worker3(Logger);
            var formaterrors = new FormatErrors(Logger);
            var othererrors = new OtherErrors(Logger);
            bool endApp = false;
            //Console.WriteLine("Консольный калькулятор сложения 2-х чисел\r");
            //Console.WriteLine("------------------------\n");
            while (!endApp)
            {
                string num1 = "";
                string num2 = "";
                double result = 0;
                double doubleNum1;
                double doubleNum2;
                Calculate calculate = new Calculate();
                try
                {
                    worker1.Work();
                    //Console.Write("Введите 1-ое число: ");
                    num1 = Console.ReadLine();
                    doubleNum1 = Convert.ToDouble(num1);
                    //double.TryParse(num1, out doubleNum1);
                    worker2.Work();
                    //Console.Write("Введите 2-ое число: ");
                    num2 = Console.ReadLine();
                    doubleNum2 = Convert.ToDouble(num2);
                    //double.TryParse(num2, out doubleNum2);
                    result = calculate.AddOperation(doubleNum1, doubleNum2);
                    Console.WriteLine("Результат: {0:0.##}\n", result);
                    worker3.Work();
                }
                catch (FormatException)
                {
                    formaterrors.Err();
                    //Console.WriteLine("Вы ввели не число, пожалуйста введите число");
                }
                catch (Exception e)
                {
                    othererrors.Err();
                    //Console.WriteLine("Возникла ошибка при сложении чисел.\n - Детали: " + e.Message);
                }

            }
            return;
        }
    }

    public interface Ilogger
    {
        void Event(string message);
        void Error(string message);
    }
   
    public interface IWorker
    { 
        void Work();
    }
    public interface IErrors 
    {
        void Err();
    }

        
}

