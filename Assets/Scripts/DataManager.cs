using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // 1. The static reference, allowing global access: DataManager.Instance
    public static DataManager Instance { get; private set; }

    // 2. The data we want to save between scenes
    public SaveData highscoreData;

    // This method runs before Start()
    private void Awake()
    {
        // 3. Singleton Check (Crucial for persistence):
        // If an instance already exists (i.e., this is a duplicate from a scene reload)
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        // 4. Set the Instance and prevent its destruction
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }
    public void SaveHighScore()
    {
        // 1. Convert the SaveData object into a JSON string
        string json = JsonUtility.ToJson(highscoreData);

        // 2. Define the path where the file will be saved
        string path = Application.persistentDataPath + "/savegame.json";

        // 3. Write the string to the file
        File.WriteAllText(path, json);
    }
    private void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savegame.json";

        if (File.Exists(path))
        {
            // 1. Read the JSON string from the file
            string json = File.ReadAllText(path);

            // 2. Convert the JSON string back into the SaveData object
            highscoreData = JsonUtility.FromJson<SaveData>(json);
        }
        else
        {
            // If no file exists, create a new SaveData object with defaults
            highscoreData = new SaveData { highScore = 0 };
        }
    }
}
