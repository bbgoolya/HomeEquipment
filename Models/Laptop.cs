using HomeEquipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeEquipment.Models
{
    class Laptop : HomeEquipmentParent, IWireFeaturesEquipment
    {
        public int MemoryRAM { get; set; }
        public Laptop(string _name, MyBrand _brand, int _amperageInner, float _weight, int _memoryRAM) : base(_name, _brand, _amperageInner, _weight)
        {
            MemoryRAM = _memoryRAM;
        }

        public void PlugIn()
        {
            Console.WriteLine($"{Name} вставлен в розетку");
        }
        public void TurnOn()
        {
            Console.WriteLine($"{Name} включен!!!");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Name} выключен!!!");
        }

        public void PlugOut()
        {
            Console.WriteLine($"{Name} вытащен из розетки!!!");
        }
    }
}
