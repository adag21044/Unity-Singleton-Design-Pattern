using System;

/// <summary>
/// PlayerData holds all player related data to be saved.
/// </summary>
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
