# Unity Singleton Pattern 

This project is designed to be an **example** of the **Singleton Pattern** in Unity using C#. It demonstrates how to implement a global and single instance of the `GameManager` class to handle game-wide variables such as score.

## Features

- Singleton-based `GameManager` class
- Global access to the `GameManager` instance
- Simple score system
- `Enemy` class interacting with the `GameManager`

## Scripts

- GameManager.cs
- Enemy.cs

## Explanation

### Singleton Pattern

The `GameManager` class is implemented as a singleton, meaning there will only be **one instance** of it throughout the game's lifetime. This is useful for managing global game states like score, player health, level progression, and more.

## GameManager.cs

```csharp
public class GameManager
{
    private static GameManager instance;
    private int score = 0;

    private GameManager() { }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }
}
```

## Enemy.cs
```csharp
public class Enemy : MonoBehaviour
{
    public GameObject enemy;

    public void Death()
    {
        GameManager gameManager = GameManager.Instance;
        Destroy(enemy);
        gameManager.IncreaseScore(10);
    }
}
```

## How It Works

- `GameManager.Instance` ensures that there is only one instance of `GameManager`.
- When an enemy dies, it calls `IncreaseScore()` on the singleton instance and increases the score by 10.
- The score is globally managed and can be accessed from anywhere via `GameManager.Instance`.

## Why Singleton?

The singleton pattern is widely used for:

- Game Managers
- Audio Managers
- UI Managers
- Score Managers
- Configurations

It prevents creating multiple instances of critical managers accidentally.

## Notes

> This is a simplified example. In real Unity projects, it is common to make singleton managers inherit from `MonoBehaviour` when they need access to Unity's lifecycle methods (`Start()`, `Update()`, etc.).

## License

This project is open-source and free to use.

