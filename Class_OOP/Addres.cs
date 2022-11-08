// using System;

// /*
// скрытые поля, конструкторы с параметрами и без параметров, методы, свойства,
//  перегруженные арифметические и\или условные операторы.
// */


// namespace Class_OOP
// {
//     class IP
//     {
//         Вводим переменные
//         string name;
//         string country;
//         string city;
//         string street;
//         int house;
//         int index;
//         public void Alpha()
//         {
//             /**
//             Это основной класс в котором просто
//             * Вводим значения
//             * Проверка на надобность сменить что либо
//             */

//             Console.Write("Name is: ");
//             name = Convert.ToString(Console.ReadLine());
            
//             Console.Write("County is: ");
//             country = Console.ReadLine();

//             Console.Write("City is: ");
//             city = Console.ReadLine();

//             Console.Write("Street is: ");
//             street = Console.ReadLine();
 
//             Console.Write("House is: ");
//             Delta0();

//             Console.Write("Postal code is: ");
//             Delta1();

//             Beta();
//         }
        
//         void Beta()
//         {
//             // Вот тут уже проводим это проверку надо ли что то менять если да то что

//             Console.WriteLine($"Postal address of {name} is: {index}, {country}, {city}, {street},{house}");

//             Console.Write("Would you like to change something?(Y/N) ");
//             string check = Console.ReadLine();

//             if (check == "Y") Gamma();
//             else Console.WriteLine("Well, Good luck!");
//         }
//         void Gamma()
//         {
//             // Тут делаем конкретные действия для замены

//             Console.Write("Please, write what you would like to change: ");
//             string change = Console.ReadLine();

//             if (change == "Name") NameSwap();
//             else if (change == "Country") CountrySwap();
//             else if (change == "City") CitySwap();
//             else if (change == "Street") StreetSwap();
//             else if (change == "House") HouseSwap();
//             else if (change == "Postal code") CodeSwap();

//             // Вводим переменные
//         string name;
//         string country;
//         string city;
//         string street;
//         int house;
//         int index;
//         public void Alpha()
//         {
//             /**
//             Это основной класс в котором просто
//             * Вводим значения
//             * Проверка на надобность сменить что либо
//             */

//             Console.Write("Name is: ");
//             name = Convert.ToString(Console.ReadLine());
            
//             Console.Write("County is: ");
//             country = Console.ReadLine();

//             Console.Write("City is: ");
//             city = Console.ReadLine();

//             Console.Write("Street is: ");
//             street = Console.ReadLine();
 
//             Console.Write("House is: ");
//             Delta0();

//             Console.Write("Postal code is: ");
//             Delta1();

//             Beta();
//         }
        
//         void Beta()
//         {
//             // Вот тут уже проводим это проверку надо ли что то менять если да то что
//         void NameSwap()
//             {
//                 Console.Write("New name is: ");
//                 name = Console.ReadLine();
//             }
//             void CountrySwap()
//             {
//                 Console.Write("New country is: ");
//                 country = Console.ReadLine();
//             }
//             void CitySwap()
//             {
//                 Console.Write("New city is: ");
//                 city = Console.ReadLine();
//             }
//             void StreetSwap()
//             {
//                 Console.Write("New street is: ");
//                 street = Console.ReadLine();
//             }
//             void HouseSwap()
//             {
//                 Console.Write("New house is: ");
//                 Delta0();
//             }
//             void CodeSwap()
//             {
//                 Console.Write("New postal code is: ");
//                 Delta0();
//             }

//             Beta();
//         } 
//         void Delta0()
//         {
//             // Проверяем целое положительно число ли это(для номера дома)

//             try
//             {
//                 house = Convert.ToInt32(Console.ReadLine());
//                 if (house <= 0)
//                 {
//                     Console.WriteLine("You need to enter a positive integer, try again");
//                     house = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
//             catch
//             {
//                 Console.WriteLine("You need to enter a positive integer, try again");
//                 house = Convert.ToInt32(Console.ReadLine());
//             }
//         }
//         void Delta1()
//         {
//             // Проверяем целое положительно число ли это(для индекса)

//             try
//             {
//                 index = Convert.ToInt32(Console.ReadLine());
//                 if (index <= 0)
//                 {
//                     Console.WriteLine("You need to enter a positive integer, try again");
//                     index = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
//             catch
//             {
//                 Console.WriteLine("You need to enter an integer, try again");
//                 index = Convert.ToInt32(Console.ReadLine());
//             }
//         }

//         /**
//         Я задумывал сделать проверку на ввод строки для других переменных
//         Но на мой взгяляд это было не совсем грамотно
//         Потому что 
//         * В названии фирмы могут использоваться и цифры и знаки препинания и тд("ООО" Айболит-1)
//         * Страна тоже может писаться с тире(Синт-Эстатиус)
//         * Город и подавно(Нью-Йорк)
//         * С улицей так же история(12-го Апреля)
//         */
//     }
// }