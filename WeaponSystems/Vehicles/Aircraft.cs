using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems
{
    public class Aircraft : Vehicle
    {
        public virtual void Fly()
        {
            Console.WriteLine("Aircraft is flying");
        }
        public override void Move()
        {
            Fly();
        }

        public override void Start()
        {
            Console.WriteLine("Aircraft engine on");
        }

        public override void Fuel()
        {
            Console.WriteLine("Filled JP8");
        }
        public override void Maintain()
        {
            Console.WriteLine("Down for maintanence");
        }
    }
}
