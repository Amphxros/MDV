
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image enemy_image; //icono de sprite del enemigo
    public Text livesText, stageText,levelScoreText,sessionScoreText; //textos de nº de vidas, nº de nivel puntuacion de nivel y total
    public RectTransform enemyPanel, infoPanel, gameOverPanel; //paneles que contendran informacion
    private int enemiesLeft; //numero de enemigos restantes

    void Start()
    {
       GameManager.getInstance().SetUIManager(this);
       
    }
    public void Init(int numLives, int numEnemies)
    {
        //vidas
        livesText.text = numLives.ToString();
        
        //destruimos los iconos si existen
        if (enemyPanel.childCount > 0)
        {
            foreach(Transform t in enemyPanel.transform)
            {
                Destroy(t.gameObject);
            }
        }
        enemiesLeft = numEnemies;
        //instancia n enemigos
        for(int i=0;i<numEnemies; i++)
        {
            Instantiate(enemy_image, enemyPanel.transform);
        }

        infoPanel.gameObject.SetActive(false);
        gameOverPanel.gameObject.SetActive(false);

    }
    /// <summary>
    /// actualiza el texto livesText
    /// </summary>
    /// <param name="numLives"> numero de vidas</param>
    public void UpdateLives(int numLives)
    {
        livesText.text = numLives.ToString();
    } 

    /// <summary>
    /// activa el panel correspondiente en funcion de si podemos seguir jugando
    /// </summary>
    /// <param name="levelScore"> puntuacion de ese nivel</param>
    /// <param name="sessionScore"> puntuacion  total</param>
    /// <param name="level">nº del nivel</param>
    /// <param name="playing">si hemos superado ese nivel</param>
    public void Score(int levelScore, int sessionScore, int level, bool playing)
    {
        if (playing)
        {
            stageText.text = level.ToString();
            levelScoreText.text = levelScore.ToString();
            sessionScoreText.text = sessionScore.ToString();
        }

        infoPanel.gameObject.SetActive(playing);
        gameOverPanel.gameObject.SetActive(!playing);

    }

    /// <summary>
    /// desactiva el ultimo hijo del panel de enemigos
    /// </summary>
    public void RemoveEnemy()
    {
        if (enemiesLeft > 0)
        {
            enemyPanel.GetChild(enemiesLeft-1).gameObject.SetActive(false);
            enemiesLeft--;
        }
    }

  }
