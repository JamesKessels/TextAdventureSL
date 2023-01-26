using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextAdventure
{
    internal class Dictionary
    {
        private List<Word> _words = new List<Word>();

        public void AddWord(Word word)
        {
            _words.Add(word);
        }

        public Word GetWord(int index)
        {
            return _words[index];
        }
    }
}
