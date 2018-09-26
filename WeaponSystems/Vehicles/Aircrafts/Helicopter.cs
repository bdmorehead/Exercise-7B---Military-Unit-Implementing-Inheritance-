using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems
{
    public class Helicopter: Aircraft
    {
        public override void Fly()
        {
            Console.WriteLine("Whampa whampa");
        }

        public override void Start()
        {
            Console.WriteLine("Spin the turbine");
        }

        public override void Maintain()
        {
            Console.WriteLine("Put back together");
        }
    }
}
