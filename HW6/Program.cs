using HW6;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int size = 3;
            // Создаем цепочку команд
            ICommand c1 = new MyCommand(null,"Команда 1");
            ICommand c3 = new MyCommand(c1, "Команда 3");
            ICommand c2 = new MyCommand(c3, "Команда 2");


            // Запускаем выполнение цепочки
            await c2.Execute();
        }
    }
}