﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Client
    {
        public delegate void Message(string message);
        public static event Message? Limit;

        private static uint count = 0;
        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
            count++;

            if (count == 2) Limit?.Invoke("Ограничение мест!");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
