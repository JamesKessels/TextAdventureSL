using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextAdventure
{
    internal class DictionaryHandler : FileHandler
    {
        public DictionaryHandler() : base(@"../../../Words/dictionary.txt")
        {
            
        }
        
        public void LoadDictionary(Dictionary dictionary)
        {
            string[] lines = File.ReadAllLines(GetFilePath());
            foreach (string line in lines)
            {
                string[] words = line.Split(", ");
                
                switch (words[1])
                {
                    case "noun":
                        dictionary.AddWord(new Noun(words[0], words[2]));
                        break;
                    case "verb":
                        dictionary.AddWord(new Noun(words[0], words[2]));
                        break;
                    case "adjective":
                        dictionary.AddWord(new Noun(words[0], words[2]));
                        break;
                    case "adverb":
                        dictionary.AddWord(new Noun(words[0], words[2]));
                        break;
                }
                
            }
        }
    }
}
