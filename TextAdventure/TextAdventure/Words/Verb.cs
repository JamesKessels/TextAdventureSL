using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    internal class Verb : Word
    {
        public string type;
        
        public Verb(string value, string type) : base(value)
        {
            this.type = type;
        }
    }
}
