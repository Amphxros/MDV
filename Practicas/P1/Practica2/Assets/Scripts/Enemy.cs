
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points;
    void OnEnable()
    {
        GameManager.getInstance().AddEnemy(); 
    }
   
  
}
