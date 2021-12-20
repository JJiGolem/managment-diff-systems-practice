using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ForDifferent.Interfaces;

namespace ForDifferent.Models
{
    class RemoteControlPanel<T> where T : ISystem
    {
        private readonly List<T> _systems;

        public RemoteControlPanel(List<T> systems)
        {
            _systems = systems;
        }

        public void ReadCommand(ref bool isOpen)
        {
            switch (Console.ReadLine())
            {
                case "start":
                    StartAllSystem();
                    break;
                case "stop":
                    StopAllSystem();
                    break;
                case "show":
                    ShowSystemsState();
                    break;
                case "exit":
                    isOpen = false;
                    Console.WriteLine("Выход из системы..");
                    break;
                default:
                    ShowCommands();
                    break;
            }
        }

        public void ShowCommands()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Пульт управления");
            Console.WriteLine("Доступные команды:");
            Console.WriteLine("1) start – включение всех систем;");
            Console.WriteLine("2) stop – выключение всех систем;");
            Console.WriteLine("3) show – вывод состояния системы;");
            Console.WriteLine("4) exit – выход из системы.");
            Console.WriteLine();
        }

        private void StartAllSystem()
        {
            if (GetSystemsState())
            {
                Console.WriteLine("Системы уже запущены");
                return;
            }

            Console.WriteLine("Начинаем процесс запуска всех систем.");
            Console.WriteLine("===============");
            foreach (var item in _systems)
            {
                Thread.Sleep(1500);
                item.Start();
                Console.WriteLine();
            }
            Console.WriteLine("===============");
            Console.WriteLine("Все системы запущены.");
        }

        private void ShowSystemsState()
        {
            if (GetSystemsState())
                Console.WriteLine("Все системы запущены");
            else
                Console.WriteLine("Системы не запущены");
        }

        private void StopAllSystem()
        {
            if (GetSystemsState() == false)
            {
                Console.WriteLine("Системы ещё не запущены");
                return;
            }

            Console.WriteLine("Вводим протокол отмены.");
            Console.WriteLine("===============");
            foreach (var item in _systems)
            {
                Thread.Sleep(1500);
                item.Stop();
                Console.WriteLine();
            }
            Console.WriteLine("===============");
            Console.WriteLine("Все системы выключены");
        }

        private bool GetSystemsState()
        {
            return _systems.TrueForAll(x => x.GetRunningState());
        }
    }
}
