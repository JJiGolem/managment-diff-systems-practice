using System;
using System.Threading;
using ForDifferent.Interfaces;

namespace ForDifferent.Models
{
    class Machine : ISystem
    {
        private MachineEngine _engine = new MachineEngine();

        public bool GetRunningState()
        {
            return _engine.IsRunning;
        }
        public void Start()
        {
            Console.WriteLine("Вставляем провод в розетку. Нажимаем на кнопку включения.");
            Thread.Sleep(3000);
            _engine.Start();
        }

        public void Stop()
        {
            Console.WriteLine("Нажимаем на кнопку выключения, вынимаем провод из розетки.");
            Thread.Sleep(3000);
            _engine.Stop();
        }
    }
}
