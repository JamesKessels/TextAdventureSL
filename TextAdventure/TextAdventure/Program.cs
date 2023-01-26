using System.Threading;
using System.Linq;
using TextAdventure;

Dictionary dictionary = new Dictionary();
DictionaryHandler dictionaryHandler = new DictionaryHandler();
dictionaryHandler.LoadDictionary(dictionary);

string input;
string defaultFallback = "You can't do that.";
string currentFallback = "";
bool running = true;

SceneHandler sceneHandler = new SceneHandler();

List<string> currentDialogue;
Scene currentScene = new Scene();
sceneHandler.LoadScene("0", currentScene);

while (running)
{    
    bool choiceMade = false;
    currentDialogue = currentScene.GetDialogue();
    currentFallback = currentScene.GetFallback();

    foreach (string line in currentDialogue)
    {
        Console.WriteLine(line);
    }

    while (!choiceMade)
    {
        if (!currentScene.GetChoices().Contains("none"))
        {
            input = Console.ReadLine();
        }
        else
        {
            input = "none";
        }

        if (currentScene.GetChoices().Contains(input.ToLower()))
        {
            choiceMade = true;
            int index = currentScene.GetChoices().IndexOf(input.ToLower());
            List<string> nextScenes = currentScene.GetNextScenes();
            if (nextScenes[index] == "end")
            {
                running = false;
            }
            else
            {
                currentScene = new Scene();
                sceneHandler.LoadScene(nextScenes[index], currentScene);
            }
        }
        else
        {
            if (currentFallback != "")
            {
                Console.WriteLine(currentFallback);
            }
            else
            {
                Console.WriteLine(defaultFallback);
            }
            Console.WriteLine(currentDialogue.Last());
        }
    }
}

Console.WriteLine("Thank you so much for playing my game.");