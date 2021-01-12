using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points;
    void Start()
    {
        GameManager.GetInstance().AddEnemy();
    }
    void OnDestroy()
    {
        if (gameObject.scene.isLoaded) //Was Deleted
        {
            GameManager.GetInstance().EnemyDestroyed(points);
        }
    }
}
