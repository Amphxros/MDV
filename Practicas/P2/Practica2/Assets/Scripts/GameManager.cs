
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private static GameManager instance;
    public static GameManager getInstance() {  return instance;}

    private UIManager ui_manager;

    [SerializeField]
    private string[] scenes_in_order; //array de escenas

    public int vidas; //vidas maximas
    private int curr_vidas; //vidas actuales
    
    private int levelScore=0; //puntuacion de nivel
    private int sessionScore=0; //puntuacion total de partida

    private int numEnemys = 0; //numero de enemigos
    private int stage; //indice del nivel

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);

        stage = 0;
    }

    void Start()
    {
        curr_vidas = vidas;
        levelScore = 0;
    }

    /// <summary>
    /// inicializa el uimanager y le pasa informacion inicial
    /// </summary>
    /// <param name="uim"></param>
    public void SetUIManager(UIManager uim)
    {
        ui_manager = uim;
        uim.Init(curr_vidas, numEnemys);
    }

    /// <summary>
    /// resta vidas al jugador,
    /// </summary>
    /// <returns> vidas<=0 </returns>
    public bool PlayerDestroyed()
    {
        curr_vidas--;
        ui_manager.UpdateLives(curr_vidas);
        return curr_vidas <= 0;
    }

    /// <summary>
    /// añade puntos y actualiza la interfaz
    /// </summary>
    /// <param name="destructionPoints"></param>
    public void EnemyDestroyed(int destructionPoints)
    {
        levelScore += destructionPoints;
        sessionScore += destructionPoints;
        ui_manager.RemoveEnemy();
    }

    /// <summary>
    /// añade enemigos, necesario para la interfaz
    /// </summary>
    public void AddEnemy()
    {
        numEnemys++;
    }

    /// <summary>
    /// cambia a una escena
    /// </summary>
    /// <param name="scene_name"> nombre de escena</param>
    public void ChangeScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    /// <summary>
    /// cambia de nivel si ha ganado y si hay niveles disponibles, si no lo lleva al menu
    /// </summary>
    private void NextLevel()
    {
        stage++;
        if (stage >= scenes_in_order.Length)
        {
            GameOver();
        }
        else
        {
            ChangeScene(scenes_in_order[stage]);
        }
        numEnemys = 0;
        levelScore = 0;
    }

    /// <summary>
    /// muestra la interfaz correspondiente
    /// </summary>
    /// <param name="playerWon"> si has ganado = true</param>
    public void FinishLevel(bool playerWon)
    {
        ui_manager.Score(levelScore, sessionScore, stage, playerWon);
        if (playerWon)
        {
            Invoke("NextLevel", 3);
        }
        else
        {
            Invoke("GameOver", 3);
        }
             
    }

    /// <summary>
    /// resetea los valores y cambia de escena al menu
    /// </summary>
    private void GameOver()
    {
        stage = 0;
        curr_vidas = vidas;
        sessionScore = 0;
        numEnemys = 0;
        levelScore = 0;
        ChangeScene("Menu");
    }
}
