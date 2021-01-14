using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Image enemy_image;
    public Text livesText, stageText,levelScoreText,sessionScore;
    public RectTransform enemyPanel;
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
    }

    public void UpdateLives(int numLives)
    {
        livesText.text = numLives.ToString();
    }

    public void RemoveEnemy()
    {
        if (enemiesLeft > 0)
        {
            enemiesLeft--;
            enemyPanel.GetChild(enemiesLeft).gameObject.SetActive(false);
        }
    }

  }
