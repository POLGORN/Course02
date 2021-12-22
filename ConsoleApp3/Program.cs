using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace room_properties_class
{   // опишем класс "комната"
    class  Room
    {
        // поля
        public double dlina;
        public double shirina;
        public  double visota;
        public int windows;
       
        // функция вычисления площади
        public void plosh ()
        {
            double pl = dlina*shirina; 
            Console.WriteLine("Площадь комнаты: "+pl+" кв.м.");
        }
        
        // функция вычисления обьема
        public void objem ()
        {
            double obj = dlina*shirina*visota;
            Console.WriteLine("Обьем комнаты: " +obj+ " куб.м.");
        }
    }
    class Program
    {
       
        static void Main()
        {
            // создадим объект класса Room по имени myRo
            Room myRo = new Room();
            
            Console.WriteLine("Введите длину комнаты: ");
            myRo.dlina = Convert.ToDouble(Console.ReadLine());
             
            Console.WriteLine("Введите ширину комнаты: ");
            myRo.shirina = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Введите высоту комнаты: ");
            myRo.visota = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Введите количество окон: ");
            myRo.windows = Convert.ToInt16(Console.ReadLine());
   
            myRo.plosh();
            myRo.objem();
            Console.WriteLine("Количество окон: " + myRo.windows);
            Console.ReadLine(); 
        }
    }    
}
