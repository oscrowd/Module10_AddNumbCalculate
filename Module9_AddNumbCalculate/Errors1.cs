using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module10_AddNumbCalculate
{
    public class FormatErrors : IErrors
    {
        Ilogger Logger { get; }
        public FormatErrors(Ilogger logger)
        {
            Logger = logger;
        }
        public void Err()
        {
            Logger.Error("Работа калькулятора прервана. \n Ошибка формата данных: Вы ввели не число, пожалуйста введите число");
            Thread.Sleep(3000);
        }
    }
    public class OtherErrors : IErrors
    {
        Ilogger Logger { get; }
        public OtherErrors(Ilogger logger)
        {
            Logger = logger;
        }
        public void Err()
        {
            Logger.Error("Работа калькулятора прервана. \n Возникла непредвиденная ошибка. Обратитесь к разработчикам");
            Thread.Sleep(2000);
        }
    }
}
