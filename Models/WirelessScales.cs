using HomeEquipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeEquipment.Models
{
    class WirelessScales : HomeEquipmentParent, IBasicFeaturesEquipment
    {
        public int MaxWeight { get; set; }
        public WirelessScales(string _name, MyBrand _brand, int _amperageInner, float _weight, int _maxWeight) : base(_name, _brand, _amperageInner, _weight)
        {
            MaxWeight = _maxWeight;
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
