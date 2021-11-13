using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeEquipment.Interfaces;

namespace HomeEquipment
{
    enum MyBrand
    {
        LG = 1, SAMSUNG, INDESIT, APPLE, REDMOND, SONY
    }
    abstract class HomeEquipmentParent 
    {
        protected const int voltage = 220;
        protected string name;
        private MyBrand brand;
        public HomeEquipmentParent(string _name, MyBrand _brand, int _amperageInner, float _weight)
        {
            name = _name;
            brand = _brand;
            amperageInner = _amperageInner;
            Weight = _weight;
        }
        public MyBrand Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int amperageInner;

        public int AmperageInner
        {
            get { return amperageInner; }
            set { amperageInner = value; }
        }

        public float Weight { get; set; }


       

        public int CalcPowerOutPut()
        {
            return amperageInner * voltage;
        }
       
    }
}
