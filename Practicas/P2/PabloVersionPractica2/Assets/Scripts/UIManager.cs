using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Image enemyIconPrefab;
    public RectTransform enemyPanel;
    public Text livesText, stageText, levelScoreText, sessionScoreText;
    public GameObject infoPanel, gameOverPanel;
    private int enemiesLeft;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.GetInstance().SetUIManager(this);
    }

    public void Init(int numLives, int numEnemies)
    {
        //lives = numLives;
        livesText.text = numLives.ToString();
        if(enemyPanel.childCount > 0)
        {
            foreach (Transform child in enemyPanel.transform)
            {
                Destroy(child.gameObject);
            }
        }
        for(int i = 0; i < numEnemies; i++)
        {
            Instantiate(enemyIconPrefab, enemyPanel.transform);
        }
        enemiesLeft = numEnemies;
    }

    public void UpdateLives(int numLives)
    {
        livesText.text = numLives.ToString();
    }

    public void RemoveEnemy()
    {
        if(enemiesLeft > 0)
        {
            if (enemyPanel != null)
                enemyPanel.GetChild(enemiesLeft-1).gameObject.SetActive(false);
        }
        enemiesLeft--;
    }
    public void Score(int levelScore, int sessionScore, int level, bool playing)
    {
        if(playing)
        {
            stageText.text = level.ToString();
            levelScoreText.text = levelScore.ToString();
            sessionScoreText.text = sessionScore.ToString();
        }

        infoPanel.SetActive(playing);
        gameOverPanel.SetActive(!playing);
    }
}
