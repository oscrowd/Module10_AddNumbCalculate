using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module9_AddNumbCalculate
{
    public class Worker1 : IWorker
    {
        Ilogger Logger { get; }
        public Worker1 (Ilogger logger) 
        { 
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Калькулятор начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Введите 1-ое число:");

        }
    }
    public class Worker2 : IWorker
    {
        Ilogger Logger { get; }
        public Worker2(Ilogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            Logger.Event("Первое число принято");
            Thread.Sleep(3000);
            Logger.Event("Введите 2-ое число:");

        }
    }
    public class Worker3 : IWorker
    {
        Ilogger Logger { get; }
        public Worker3 (Ilogger logger)
        {
            Logger = logger;
        }
        public void Work()
        {
            //Logger.Event("Worker3 начал свою работу");
            //Thread.Sleep(3000);
            Logger.Event("Калькулятор закончил свою работу");

        }
    }

}
