using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points;
    void OnEnable()
    {
        GameManager.getInstance().AddEnemy(); 
    }
    void OnDestroy()
    {
        if (gameObject.scene.isLoaded)
            GameManager.getInstance().EnemyDestroyed(points);
    }

  
}
