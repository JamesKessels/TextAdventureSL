using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    abstract class FileHandler
    {
        public FileHandler(string filepath)
        {
            _filepath = filepath;
        }
        
        private readonly string _filepath;

        public string GetFilePath()
        {
            return _filepath;
        }
    }
}
