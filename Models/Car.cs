using System;
using System.Threading;
using ForDifferent.Interfaces;

namespace ForDifferent.Models
{
    class Car : ISystem
    {
        private CarEngine _engine = new CarEngine();

        public bool GetRunningState()
        {
            return _engine.IsRunning;
        }
        public void Start()
        {
            Console.WriteLine("Ключ зажигания повернут. Начинаем запуск двигателя.");
            Thread.Sleep(3000);
            _engine.Start();
        }

        public void Stop()
        {
            Console.WriteLine("Переводим коробку передач на нейтральную. Поворачиваем ключ зажигания обратно.");
            Thread.Sleep(3000);
            _engine.Stop();
        }
    }
}
