﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    internal class Adjective : Word
    {
        public string type;

        public Adjective(string value, string type) : base(value)
        {
            this.type = type;
        }
    }
}
