using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2048
{
    internal class Model
    {
            Map map; // Создаем класс модель
            static Random random = new Random(); // Вводим рандом
            bool isGameOver; // Булеан для проверки состояния игры
            bool moved; // Булеан для проверки движения
            public int score = 0; // Переменная-счет
            public int Score()
            {
                return score;
            }
            public int size 
            { 
                get { return map.size; } 
            }
            public Model(int size) // Создаем нашу модель с размером
            {
                map = new Map(size);
            }
            public void Start() // Начинаем всю игру и создаем начальное прле
            {
                isGameOver = false; // Пока игра не окончена
                for (int x = 0; x < size; x ++) // Перебирая вообще всё
                    for (int y = 0; y < size; y++)
                        map.Set(x, y, 0); // Создай нули
                AddRandomNumber(); // И две циферки
                AddRandomNumber();
            }
            public bool IsGameOver() // Здесь описаны условия при которых игра кончается
            {
                if (isGameOver) // Если всё то всё, есои нет то проверяем закончилась ли игра
                    return isGameOver;
                for (int x = 0; x < size; x++) // Если ещё есть пусто
                    for (int y = 0; y < size; y++) // То игра продолжается
                        if (map.Get(x, y) == 0)
                            return false;
                for (int x = 0; x < size; x++) // Посмотрим а можно ли вообще двигаться
                    for (int y = 0; y < size; y++)
                        if (map.Get(x, y) == map.Get(x + 1, y) || // Если в какой то стороне ещё есть одинаковая
                            map.Get(x, y) == map.Get(x, y + 1)) // плитка то Have Fun!
                            return false;
                for (int x = 0; x < size; x++) // Если достигнута плитка 2048 то конец
                    for (int y = 0; y < size; y++)
                        if (map.Get(x, y) == 2048)
                            return true;
                isGameOver = true;
                return isGameOver;
            }
            private void AddRandomNumber() // Тут создаем наше случайное число
            {
                int n = 0;
                if (isGameOver) return; // Для тго что бы числа не накладывались
                for (int j = 0; j < 100; j++) // Пусть он сделает несколько попыток для заполнения
                {
                    int x = random.Next(0, map.size); // В случайном месте
                    int y = random.Next(0, map.size);
                    if (map.Get(x, y) == 0)
                    {
                        n = random.Next(0, 10);
                        if (n == 0) // Если выпало 0 = 4(10% шанс)
                            map.Set(x, y, 4);
                        else // Если выпало что то другое то = 2(90% шанс)
                            map.Set(x, y, 2);
                        return;
                    }
                }
            }
            void Lift (int x, int y, int sx, int sy) // Сам метод смещения(x у = откуда sx sy = куда)
            {
                if (map.Get (x, y) > 0) // Если 0 то не двигай
                    while (map.Get(x + sx, y + sy) == 0) // Двигаемся до тех пор пока вообще можно(есть пустая клетка)
                    {
                        map.Set (x + sx, y + sy, map.Get(x, y)); // Ставим нашу плитку на новое место
                        map.Set (x, y, 0); // И очищаем со старого
                        x += sx; // Вдруг можно ещё дальше сместится
                        y += sy;
                        moved = true;
                    }
            }
            void Join (int x, int y, int sx, int sy) // Этот метод скливает плитки
            {
                if (map.Get(x, y) > 0) // Для всех не 0 чисел
                    if (map.Get(x + sx, y + sy) == map.Get(x, y)) // При одинаковых плитках
                        {
                            map.Set(x + sx, y + sy, map.Get(x, y) * 2); // Удвой
                            score += map.Get(x, y) * 2; // Сохрани результат
                            while (map.Get(x - sx, y - sy) > 0) // Если в противоположной стороне ещё что то есть
                            {
                                map.Set(x, y, map.Get(x - sx, y - sy)); // То замени текущее значение на него
                                x -= sx;
                                y -= sy;
                            }
                            map.Set(x, y, 0); // Когда всё обеденили то заполним опустевшие клетки 0
                            moved = true;
                        }
            }
            public void Left() // При нажатии влево
            {
                moved = false; // Начинаем с состояния покоя
                for (int y = 0; y < map.size; y++) // Для всего что есть
                    for (int x = 1; x < map.size; x++) // Кроме первого столбца
                        Lift(x, y, -1, 0); // Организуем смещение влево 
                for (int y = 0; y < map.size; y++)
                    for (int x = 1; x < map.size; x++)
                        Join(x, y, -1, 0); // И склеиваются
                if (moved) AddRandomNumber();
            }
            public void Right() // При нажатии вправо
            {
                moved = false; // Здесь всё перебираем СПРАВА НАЛЕВО
                for (int y = 0; y < map.size; y++)
                    for (int x = map.size - 2; x >= 0; x--) // От второго справа столбца
                        Lift(x, y, +1, 0); // Двигаем вправо
                for (int y = 0; y < map.size; y++)
                    for (int x = map.size - 2; x >= 0; x--) // х только здесь уменьшается
                        Join(x, y, +1, 0);
                if (moved) AddRandomNumber();
            }
            public void Up() // При нажатии вверх
            {
                moved = false;
                for (int x = 0; x < map.size; x++)
                    for (int y = 1; y < map.size; y++) // От второй строки 
                        Lift(x, y, 0, -1); // Двигаем вверх
                for (int x = 0; x < map.size; x++)
                    for (int y = 1; y < map.size; y++)
                        Join(x, y, 0, -1);
                if (moved) AddRandomNumber();
            }
            public void Down() // При нажатии вниз
            {
                moved = false; // СНИЗУ НАВЕРХ
                for (int x = 0; x < map.size; x++)
                    for (int y = map.size - 2; y >= 0; y-- ) // От 2 снизу 
                        Lift(x, y, 0, +1); // Двигаем вниз
                for (int x = 0; x < map.size; x++)
                    for (int y = map.size - 2; y >= 0; y-- )
                        Join(x, y, 0, +1);
                if (moved) AddRandomNumber();
            }
            public int GetMap( int x, int y ) // Создаем класс 
            {
                return map.Get(x, y);
            }
    }
}