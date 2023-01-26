using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextAdventure
{
    internal class Scene
    {
        private List<string> _dialogue = new List<string>();
        private List<string> _choices = new List<string>();
        private List<string> _nextScenes = new List<string>();
        private string _fallback = "";
        
        public void AddDialogue(string dialogue)
        {
            _dialogue.Add(dialogue);
        }

        public void AddChoice(string choice)
        {
            _choices.Add(choice);
        }
        
        public void AddNextScene(string nextScene)
        {
            _nextScenes.Add(nextScene);
        }
        
        public void SetFallback(string fallback)
        {
            _fallback = fallback;
        }

        public List<string> GetDialogue()
        {
            return _dialogue;
        }

        public List<string> GetChoices()
        {
            return _choices;
        }

        public List<string> GetNextScenes()
        {
            return _nextScenes;
        }

        public string GetFallback()
        {
            return _fallback;
        }
    }
}
