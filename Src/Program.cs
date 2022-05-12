using System;
using System.IO;
using System.Text;

namespace PM03
{
    //Обьявления класса и его полей
    public class Auto : IComparable
    {
        public string markaauto;
        public string modelauto;
        public string cenaauto;

        public Auto(string marka, string model, string cena)
        {
            this.markaauto = marka;
            this.modelauto = model;
            this.cenaauto = cena;
        }

        public string ToString()
        {
            return string.Format("Марка автомобиля: {0}  Модель автомобиля: {1} Цена автомобиля: {2}", markaauto, modelauto, cenaauto);
        }

        // Сортировка массива по 2 параметрам.
        public int CompareTo(object o)
        {
            Auto c = o as Auto;
            if (c != null)
            {
                int result = modelauto.CompareTo(c.modelauto);
                if (result != 0)
                {
                    return result;
                }
                return cenaauto.CompareTo(c.cenaauto);
            }
            else
            {
                throw new Exception("К сожалению невозможно сравнить эти два объекта");
            }
        }

    }

    // Создание массива указателей
    public class Driver
    {
        int cntAutos;
        public Auto[] Autos;

        public Driver(int cntAutos)
        {
            this.cntAutos = cntAutos;
            Autos = new Auto[cntAutos];
        }

        // Заполнение полей класса
        public void Fill()
        {
            string marka;
            string model;
            string cena;
            for (int i = 0; i < this.cntAutos; i++)
            {
                Console.WriteLine("Марка автомобиля:");
                marka = Console.ReadLine();
                Console.WriteLine("Модель автомобиля:");
                model = Console.ReadLine();
                Console.WriteLine("Цена автомобиля:");
                cena = Console.ReadLine();
                this.Autos[i] = new Auto(marka, model, cena);
            }
        }

        public void Sort()
        {
            Array.Sort(this.Autos);
        }

        // Запись результата программы в тестовый файл
        public void PrintToFile()
        {
            using (StreamWriter file = new StreamWriter("Resultatprogrammi.txt", false, Encoding.UTF8))
            {
                foreach (Auto c in this.Autos)
                {
                    file.WriteLine(c.ToString());
                }
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Количество автомобилей:");
            int cntAutos = Convert.ToInt32(Console.ReadLine());
            Driver drivers = new Driver(cntAutos);
            drivers.Fill();
            drivers.Sort();
            drivers.PrintToFile();
            Console.WriteLine("Результат приложения выведен в файл Resultatprogrammi");
        }
    }
}



