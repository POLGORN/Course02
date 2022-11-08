using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); // Избавляемся от параметра static
            program.Start();
        }
        Model model; // Создадим класс модель
        void Start() // Фундаментальная структура которая соединяет всё
        {
            Model model = new Model(4); // Создаем модель 4х4
            model.Start();
            while (true) // Пока игра идёт
            {
                Show(model);
                switch (Console.ReadKey(false).Key) // faulse стоит что бы ничего не выводилось
                {
                    case ConsoleKey.LeftArrow:  model.Left(); break; // Контроллер программы
                    case ConsoleKey.RightArrow: model.Right(); break; // И оператор вывода
                    case ConsoleKey.UpArrow:    model.Up(); break;
                    case ConsoleKey.DownArrow:  model.Down(); break;
                    case ConsoleKey.Escape:     return;
                }
            }
        }
        void Show(Model model) // Функция которая показывает всё
        {
            for (int y = 0; y < model.size; y ++) // Создаем двойной цикл который
                for (int x = 0; x < model.size; x++) // переберёт все элементы
                {
                    Console.SetCursorPosition (x * 5 + 5, y * 2 + 2); // Теперь надо вывести на экран какая цифра
                    int number = model.GetMap(x, y); // Расположена в данном месте
                    Console.Write(number == 0 ? ".   " : number.ToString() + "  "); // Если чисто 0 то выведи поле, если нет то создай пустую строку 

                }
            Console.WriteLine();
            int scr = model.Score(); 
            if (model.IsGameOver()) // Проевяет закончить игру или нет 
                Console.WriteLine ("Well played! Your score is " + scr);
            else
                Console.WriteLine ("Have Fun!");
        } 
    }
}