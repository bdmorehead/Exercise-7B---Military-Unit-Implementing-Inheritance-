﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems
{
    public class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Lets go!!!");
        }

        public virtual void Start()
        {
            Console.WriteLine("Its deadlined");
        }

        public virtual void Fuel()
        {
            Console.WriteLine("Vehicle is full of fuel");
        }

        public virtual void Maintain()
        {
            Console.WriteLine("Vehicle is down for maintenance");
        }

    }
}
