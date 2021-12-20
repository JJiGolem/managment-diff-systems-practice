using System;
using System.Threading;
using ForDifferent.Interfaces;

namespace ForDifferent.Models
{
    class Rocket : ISystem
    {
        private RocketEngine _engine = new RocketEngine();

        public bool GetRunningState()
        {
            return _engine.IsRunning;
        }
        public void Start()
        {
            Console.WriteLine("Вводим секретные коды и нажимаем на кнопку запуска.");
            Thread.Sleep(3000);
            _engine.Start();
        }

        public void Stop()
        {
            Console.WriteLine("Вводим код деактивации и нажимаем на кнопку отмены.");
            Thread.Sleep(3000);
            _engine.Stop();
        }
    }
}
