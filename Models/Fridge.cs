using HomeEquipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeEquipment.Models
{
    class Fridge : HomeEquipmentParent, IWireFeaturesEquipment
    {
        public decimal Volume { get; set; }
        public Fridge(string _name, MyBrand _brand, int _amperageInner, float _weight, decimal _volume) : base(_name, _brand, _amperageInner, _weight)
        {
            Volume = _volume;
        }
        public void PlugIn()
        {
            Console.WriteLine($"{Name} вставлен в розетку");
        }
        public void PlugOut()
        {
            Console.WriteLine($"{Name} вытащен из розетки!!!");
        }
        public void TurnOn()
        {
            Console.WriteLine($"{Name} включен!!!");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Name} выключен!!!");
        }
    }
}
