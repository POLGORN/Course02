using System;

namespace Class_OOP
{
    class Alpha
    {
        private int zero; // Вводим скрытые перменные
        private string name;
        private string country;
        private string city;
        private string street;
        private int house;
        private int index;
        public int Zero 
        {
            get { return zero; } // И обращения к ним
            set { zero = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
            // set 
            // { 
            //     if (value > 0) house = value;
            //     else
            //         Console.WriteLine("You need to enter a positive integer!");
            // }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
            // set
            // {
            //     if (value > 0) index = value;
            //     else
            //         Console.WriteLine("You need to enter a positive integer!");
            // }
        }
        public void HouseCheck()
        {
            try
            {
                House = Convert.ToInt32(Console.ReadLine());
                if (House <= 0)
                {
                    Console.WriteLine("You need to enter a positive integer, try again");
                    House = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("You need to enter a positive integer, try again");
                House = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void IndexCheck()
        {
            try
            {
                Index = Convert.ToInt32(Console.ReadLine());
                if (Index <= 0)
                {
                    Console.WriteLine("You need to enter a positive integer, try again");
                    Index = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("You need to enter a positive integer, try again");
                Index = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Change()
        {
            Console.WriteLine($"Postal address of {Name} is: {Index}, {Country}, {City}, {Street},{House}");

            Console.Write("Would you like to change something?(Y/N) ");
            string check = Console.ReadLine();

            if (check == "Y") ChangeMove();
            else Console.WriteLine("Well, Good luck!");
        }
        void ChangeMove()
        {
            Console.Write("Please, write what you would like to change: ");
            string change = Console.ReadLine();

            if (change == "Name") NameSwap();
            else if (change == "Country") CountrySwap();
            else if (change == "City") CitySwap();
            else if (change == "Street") StreetSwap();
            else if (change == "House") HouseSwap();
            else if (change == "Postal code") CodeSwap();

            Change();
        }
        void NameSwap()
        {
            Console.Write("New name is: ");
            name = Console.ReadLine();
        }
        void CountrySwap()
        {
            Console.Write("New country is: ");
            country = Console.ReadLine();
        }
        void CitySwap()
        {
            Console.Write("New city is: ");
            city = Console.ReadLine();
        }
        void StreetSwap()
        {
            Console.Write("New street is: ");
            street = Console.ReadLine();
        }
        void HouseSwap()
        {
            Console.Write("New house is: ");
            HouseCheck();
            // House = Convert.ToInt32(Console.ReadLine());
        }
        void CodeSwap()
        {
            Console.Write("New postal code is: ");
            IndexCheck();
            // Index = Convert.ToInt32(Console.ReadLine());
        }
        
        public static bool operator <(Alpha Al, Alpha Be) // Операторы сравнения
        {
            return (Al.Zero < Be.Zero);
        }
        public static bool operator >(Alpha Al, Alpha Be)
        {
            return (Al.Zero > Be.Zero);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alpha Al = new Alpha();

            Al.Zero = 1;

            Console.Write("Name is: ");
            Al.Name = Convert.ToString(Console.ReadLine());

            Console.Write("County is: ");
            Al.Country = Convert.ToString(Console.ReadLine());

            Console.Write("City is: ");
            Al.City = Convert.ToString(Console.ReadLine());

            Console.Write("Street is: ");
            Al.Street = Convert.ToString(Console.ReadLine());

            Console.Write("House is: ");
            Al.HouseCheck();
            // Al.House = Convert.ToInt32(Console.ReadLine());

            Console.Write("Postal code is: ");
            Al.IndexCheck();
            // Al.Index = Convert.ToInt32(Console.ReadLine());

            Al.Change();

            Alpha Be = new Alpha();

            Be.Zero = 2;

            Console.Write("Name is: ");
            Be.Name = Convert.ToString(Console.ReadLine());

            Console.Write("County is: ");
            Be.Country = Convert.ToString(Console.ReadLine());

            Console.Write("City is: ");
            Be.City = Convert.ToString(Console.ReadLine());

            Console.Write("Street is: ");
            Be.Street = Convert.ToString(Console.ReadLine());

            Console.Write("House is: ");
            Be.HouseCheck();
            // Be.House = Convert.ToInt32(Console.ReadLine());

            Console.Write("Postal code is: ");
            Be.IndexCheck();
            // Be.Index = Convert.ToInt32(Console.ReadLine());

            Be.Change();

            if (Be > Al) Console.WriteLine("2nd is bigger");
            else Console.WriteLine("1st is bigger");
        }
    }
}
