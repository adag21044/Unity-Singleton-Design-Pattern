# Unity Singleton Pattern 

This project is designed to be an **example** of the **Singleton Pattern** in Unity using C#. 

## Features
- Save player information to a persistent JSON file
- Load player information from the JSON file
- Clear saved data
- User-friendly UI integration
- Singleton pattern for save manager

## Structure

### 1. PlayerData.cs
Stores player-related data.

```csharp
[Serializable]
public class PlayerData
{
    public string playerName;
    public int playerAge;
    public string favoriteColor;

    public PlayerData(string name, int age, string color)
    {
        playerName = name;
        playerAge = age;
        favoriteColor = color;
    }
}
```

### 2. PlayerFormUI.cs
Handles user input and UI interaction.

- Input Fields:
    - Name (string)
    - Age (int)
    - Favorite Color (string)

- Buttons:
    - Save: Saves entered data
    - Load: Loads saved data into input fields
    - Clear: Deletes saved data and clears input fields

### 3. SaveManager.cs
Manages the save/load/clear logic using JSON serialization.

- Singleton pattern to ensure a single instance
- Automatically sets the save path using `Application.persistentDataPath`
- Provides the following methods:
    - `Save(PlayerData data)`
    - `Load()`
    - `ClearSave()`

## Example Usage
1. Attach `PlayerFormUI` to a Canvas GameObject in your Unity scene.
2. Link UI elements (input fields and buttons) via the Inspector.
3. Play the scene.
4. Enter data and click **Save**.
5. Exit Play Mode and re-enter to test **Load**.
6. Click **Clear** to delete saved data.

## Notes
- Data is saved in JSON format inside the persistent data path.
- Input validation is included for empty fields and age conversion.
- `SaveManager` is fully independent and does not require a MonoBehaviour.

---

> This project demonstrates basic Unity data persistence using JSON and Singleton pattern.
> Easily extendable for larger projects.


