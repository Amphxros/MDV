using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public static GameManager getInstance() {  return instance;}

    public int vidas; //vidas maximas
    private int curr_vidas; //vidas actuales
    
    private int score=0;
    public int getScore() { return score; }


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);

    }


    void Start()
    {
        curr_vidas = vidas;
        score = 0;

    }

    public bool PlayerDestroyed()
    {
        curr_vidas--;
        return curr_vidas <= 0;
    }
    public void EnemyDestroyed(int destructionPoints)
    {
        score += destructionPoints;
    }
    void Update()
    {
        
    }
}
