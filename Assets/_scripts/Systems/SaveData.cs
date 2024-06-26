using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class SaveData
{
    //public CollectableTracker CollectableTracker;
    
    public string SavedScene;

    public void SaveGameProgress(string currentLevel)
    {
        SaveData data = new SaveData();
        data.SavedScene = currentLevel;

        string json = JsonUtility.ToJson(data);
        string filePath = Application.persistentDataPath + "/saveData.json";
        File.WriteAllText(filePath, json);

        Debug.Log($"Game saved at location: {filePath}");
    }

    public void LoadGameProgress()
    {
        string filePath = Application.persistentDataPath + "/saveData.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            // Save loaded data to scriptable object
            //CollectableTracker.SavedSceneName = data.CurrentLevel;
            SavedScene = data.SavedScene;

            Debug.Log("Game progress loaded successfully.");
        }
        else
        {
            Debug.Log("No save data found.");
            SavedScene = null;
        }
    }

    public void ResetGameProgress()
    {
        string filePath = Application.persistentDataPath + "/saveData.json";

        if (File.Exists(filePath))
        {
            File.Delete(filePath);
            Debug.Log("Save data cleared successfully.");
        }
        else
        {
            Debug.Log("No save data found to clear.");
        }
    }
}
