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


