﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale.Gamer
{
    public class Gamer
    {
        public string FullName { get; set; }

        public string IPAddress { get; set; }

        public List<Ship> Ships { get; set; }


        public Gamer(string fullName, string ipAddress)
        {
            FullName = fullName;
            IPAddress = ipAddress;
            Ships = new List<Ship>();
        }
    }
}
