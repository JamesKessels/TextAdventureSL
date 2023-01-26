using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    abstract class Word
    {
        public string value;

        public Word(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }
    }
}
