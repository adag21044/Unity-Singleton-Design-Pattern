using System.IO;
using UnityEngine;

/// <summary>
/// SaveManager handles all save / load / clear operations as JSON.
/// Fully Singleton and persistent across scenes.
/// </summary>
public class SaveManager
{
    private static SaveManager _instance;
    public static SaveManager Instance => _instance ??= new SaveManager();

    private readonly string savePath;

    private SaveManager()
    {
        savePath = Path.Combine(Application.persistentDataPath, "playerdata.json");
        Debug.Log($"[SaveManager] Initialized. Save path: {savePath}");
    }

    public void Save(PlayerData data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(savePath, json);
        Debug.Log($"[SaveManager] Data saved successfully.\n{json}");
    }

    public PlayerData Load()
    {
        if (!File.Exists(savePath))
        {
            Debug.LogWarning("[SaveManager] No save file found.");
            return null;
        }

        string json = File.ReadAllText(savePath);
        PlayerData data = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log($"[SaveManager] Data loaded successfully.\n{json}");
        return data;
    }

    public void ClearSave()
    {
        if (File.Exists(savePath))
        {
            File.Delete(savePath);
            Debug.Log("[SaveManager] Save file deleted.");
        }
        else
        {
            Debug.LogWarning("[SaveManager] No save file to delete.");
        }
    }
}
