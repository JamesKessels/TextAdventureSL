using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    internal class SceneHandler : FileHandler
    {
        public SceneHandler() : base(@"../../../story.txt")
        {

        }

        public void LoadScene(string sceneName, Scene scene)
        {
            string[] lines = File.ReadAllLines(GetFilePath());

            int lineToJumpTo = 0;

            lineToJumpTo = FindScene(lines, sceneName) + 1;
            LoadChoicesAndNextScenes(lines, lineToJumpTo, scene);
            LoadDialogue(lines, lineToJumpTo, scene);
            LoadFallback(lines, lineToJumpTo, scene);
        }

        public int FindScene(string[] lines, string sceneName)
        {
            int currentLine = 0;
            
            foreach (string line in lines)
            {
                if (line == "#SCENE " + sceneName + "#")
                {
                    return currentLine;
                }

                currentLine++;
            }

            return -1;
        }

        public void LoadDialogue(string[] lines, int lineToJumpTo, Scene scene)
        {
            bool textStarted = false;

            for (int i = lineToJumpTo; i < lines.Length; i++)
            {
                if (lines[i] == "end")
                {
                    return;
                }

                if (textStarted)
                {
                    scene.AddDialogue(lines[i]);
                }

                if (lines[i] == "start")
                {
                    textStarted = true;
                }
            }
        }

        public void LoadChoicesAndNextScenes(string[] lines, int lineToJumpTo, Scene scene)
        {
            for (int i = lineToJumpTo; i < lines.Length; i++)
            {
                if (lines[i] == "")
                {
                    return;
                }
                else if (lines[i].Contains("fb"))
                {
                    continue;
                }
                
                string[] choiceAndScene = lines[i].Split(" / ");
                scene.AddChoice(choiceAndScene[0]);
                scene.AddNextScene(choiceAndScene[1]);
            }
        }

        public void LoadFallback(string[] lines, int lineToJumpTo, Scene scene)
        {
            for (int i = lineToJumpTo; i < lines.Length; i++)
            {
                if (lines[i].Contains("end"))
                {
                    scene.SetFallback("");
                    return;
                }

                if (lines[i].Contains("fb"))
                {
                    scene.SetFallback(lines[i].Split(" -- ")[1]);
                    return;
                }
            }
        }
    }
}
