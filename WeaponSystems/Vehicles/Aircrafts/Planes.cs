using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems
{
    public class Plane: Aircraft
    {
        public override void Fly()
        {
            Console.WriteLine("Plane is taxiing");
        }

        public override void Start()
        {
            Console.WriteLine("Turn over the prop");
        }

    }
}
    

