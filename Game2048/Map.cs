using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game2048
{
    class Map // Класс нашей карты
    { 
        int [,] map;
        public int size { get; private set; }
       public Map(int size) // Принимает размер и создает массив
       {
           this.size = size; // Сохраняем его
           map = new int [size, size];
       }
       public int Get(int x, int y) // Метод для получения координат
       {
            if (OnMap(x, y))
                return map[x, y];
            return -1; // На всякий случай для того если в поле ничего нет
       }
        public void Set(int x, int y, int number)
        {
            if (OnMap(x, y)) // Если наш х у на карте то просто вводим число
                map[x, y] = number;
        }
       public bool OnMap(int x, int y) // Проверяем всё ли хорошо
       {
           return x >= 0 && x < size && // х больше либо равно 0 но меньше размера
                  y >= 0 && y < size; // у больше либо равно 0 но меньше размера
       } 
    }
}