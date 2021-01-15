
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points; //puntos
    void OnEnable()
    {
        GameManager.getInstance().AddEnemy(); 
    }
   
  
}
