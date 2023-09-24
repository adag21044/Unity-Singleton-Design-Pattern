using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    // Singleton instance
    private static GameManager instance;
    
    // Declare variables like score, lives, etc.
    private int score = 0;
    
    // Private constructor
    private GameManager() { }
    
    // Singleton getter
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
    
    // Increase score
    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }
    
    
}
