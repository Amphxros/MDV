
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
    private int sessionScore=0;

    private int numEnemys = 0;
    private int level;

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
        sessionScore += destructionPoints;
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

    private void NextLevel()
    {
        level++;
        if (level > scenes_in_order.Length)
        {
            level = 0;
            curr_vidas = vidas;
            sessionScore = 0;
            ChangeScene("Menu");
        }
        else
        {
            ChangeScene(scenes_in_order[level]);
        }
        numEnemys = 0;
        score = 0;
    }

    public void FinishLevel(bool playerWon)
    {
        ui_manager.Score(score, sessionScore, level, playerWon);
        if (playerWon)
        {
            Invoke("NextLevel", 3);
        }
        else
        {
            Invoke("GameOver", 3);
        }
             
    }
    private void GameOver()
    {
        level = 0;
        curr_vidas = vidas;
        sessionScore = 0;
        numEnemys = 0;
        score = 0;
        ChangeScene("Menu");
    }
}
