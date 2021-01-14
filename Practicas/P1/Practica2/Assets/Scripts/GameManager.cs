using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public static GameManager getInstance() {  return instance;}

    private UIManager ui_manager;


    [SerializeField]
    private string[] scenes_in_order;


    public int vidas; //vidas maximas
    private int curr_vidas; //vidas actuales
    
    private int score=0;
    public int getScore() { return score; }

    private int numEnemys = 0;
    private int level=0;
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

    }
    void Start()
    {
        curr_vidas = vidas;
        score = 0;

    }
    
    public void SetUIManager(UIManager uim)
    {
        ui_manager = uim;
        uim.Init(curr_vidas, numEnemys);
    }
    
    public bool PlayerDestroyed()
    {
        curr_vidas--;
        ui_manager.UpdateLives(curr_vidas);
        return curr_vidas <= 0;
    }
    public void EnemyDestroyed(int destructionPoints)
    {
        score += destructionPoints;
        ui_manager.RemoveEnemy();
    }
    public void AddEnemy()
    {
        numEnemys++;

    }
    public void ChangeScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void FinishLevel(bool playerWon)
    {

    }
}
