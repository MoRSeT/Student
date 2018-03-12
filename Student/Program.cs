using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
         public string Name { get; set; } // имя 
        public int Kurs { get; set; } // курс 
        public int Pol { get; set; } // пол 
        public Product()
        {
            Name = null;
            Kurs = 0;
            Pol = 0;
        }
        public Product(string name, int kurs, int pol)
        {
            Name = name;
            Kurs = kurs;
            Pol = pol;
        }
        public void Input()
        {
            Console.WriteLine(" Введите имя  ");
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Курс: ");
            int kurs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Пол (0 - м, 1 - ж): ");
            int pol = Convert.ToInt32(Console.ReadLine());
            Name = name;
            Kurs = kurs;
            Pol = pol;
        }
        public void Print()
        {
            Console.WriteLine("Имя: {0}, Курс: {1}, Пол: {2}", Name, Kurs, Pol);

        }
    }
}
