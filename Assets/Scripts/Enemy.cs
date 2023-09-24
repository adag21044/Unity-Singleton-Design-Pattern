using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
