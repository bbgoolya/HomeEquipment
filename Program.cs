using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeEquipment.Models;
using HomeEquipment.Interfaces;
using System.Collections;

namespace HomeEquipment
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            HomeEquipmentParent[] arrayEquipments = new HomeEquipmentParent[4];
            arrayEquipments[0] = new Television("Телевизор", MyBrand.SAMSUNG, 16, 15, 120);
            arrayEquipments[1] = new Fridge("Холодильник", MyBrand.INDESIT, 12, 80, 200 );
            arrayEquipments[2] = new Laptop("Ноутбук", MyBrand.LG, 12, 4, 16);
            arrayEquipments[3] = new WirelessScales("Кухонные весы", MyBrand.REDMOND, 7, 0.5F, 5);


            foreach (var t in arrayEquipments)
            {
                Console.WriteLine($"equipment name: {t.Name} \n brand name: {t.Brand} \n Output: {t.CalcPowerOutPut()} \n\n");
            }
            Console.WriteLine("введите начальный параметр мощности  для поиска: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("введите конечный параметр мощности  для поиска: ");

            int end = int.Parse(Console.ReadLine());
            SearchEquipmentByOutPut(arrayEquipments, start, end);
            Console.ReadLine();
        }
        public static void Sort(HomeEquipmentParent[] homeEquipmentParents)
        {
            var newSortArray = homeEquipmentParents.OrderBy(n => n.Name).ToList();
            for (int i = 0; i < homeEquipmentParents.Length; i++)
            {
                homeEquipmentParents[i] = newSortArray[i];

            }
        }
        public static void SearchEquipmentByOutPut(HomeEquipmentParent[] homeEquipmentParents, int startParameter, int endParametr)
        {
            Console.WriteLine("Приборы, соответствующие заданным параметрам: ");

            foreach (var item in homeEquipmentParents)
            {
                if (item.CalcPowerOutPut() >= startParameter && item.CalcPowerOutPut() <= endParametr)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }


    }
}
