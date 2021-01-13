using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public static GameManager getInstance() {  return instance;}


    public string[] scenes_in_order;


    public int vidas; //vidas maximas
    private int curr_vidas; //vidas actuales
    
    private int score=0;
    public int getScore() { return score; }

    private int numEnemys = 0;
    private int level;
    public void resetEnemys() { numEnemys = 0; }


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);

        level = 0;
        ChangeScene(scenes_in_order[level]);

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

    public void ChangeScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
