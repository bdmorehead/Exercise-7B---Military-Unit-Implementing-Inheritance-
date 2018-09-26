using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponSystems;


namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft a10 = new Plane();
            Plane f22 = new Plane();
            Aircraft hh60 = new Helicopter();
            Helicopter ah64 = new Helicopter();

            Tank m1 = new WeaponSystems.Tank();
            Vehicle tank = new Tank();
        }
    }
}
