using System;
using System.IO;
using UnityEngine;

[Serializable]
public class GameState
{
    public int Score;
    // Add other game state variables here (e.g., player position, health, inventory, etc.)

    public void Save(string filename)
    {
        string path = Path.Combine(Application.persistentDataPath, filename);
        try
        {
            string json = JsonUtility.ToJson(this);
            File.WriteAllText(path, json);
            Debug.Log("Game state saved to " + path);
        }
        catch (Exception e)
        {
            Debug.LogError("Failed to save game state: " + e.Message);
        }
    }

    public static GameState Load(string filename)
    {
        string path = Path.Combine(Application.persistentDataPath, filename);
        if (File.Exists(path))
        {
            try
            {
                string json = File.ReadAllText(path);
                return JsonUtility.FromJson<GameState>(json);
            }
            catch (Exception e)
            {
                Debug.LogError("Failed to load game state: " + e.Message);
            }
        }
        else
        {
            Debug.LogWarning("Save file not found at " + path);
        }
        return null;
    }
}
