using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems
{
    class Firearms
    {
        public virtual void Shoot()
        {
            Console.WriteLine("Die, Die, Die");
        }

        public virtual void Clean()
        {
           Console.WriteLine("Gun cleaned");        
        }
        public virtual void Reload()
        {
            Console.WriteLine("Rounds chambered");
        }
    }
}
