
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image enemy_image;
    public Text livesText, stageText,levelScoreText,sessionScoreText;
    public RectTransform enemyPanel, infoPanel, gameOverPanel;
    private int enemiesLeft;

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

    public void UpdateLives(int numLives)
    {
        livesText.text = numLives.ToString();
    }

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

    public void RemoveEnemy()
    {
        if (enemiesLeft > 0)
        {
            enemyPanel.GetChild(enemiesLeft-1).gameObject.SetActive(false);
            enemiesLeft--;
        }
    }

  }
