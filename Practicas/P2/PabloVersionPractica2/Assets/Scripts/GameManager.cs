using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField]
    private string[] scenesInOrder;

    private int lives = 3;
    private int stage = 1;
    private int enemiesInLevel;
    private int levelScore, sessionScore;

    private UIManager theUIManager;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static GameManager GetInstance()
    {
        return instance;
    }

    public bool PlayerDestroyed()
    {
        lives--;

        theUIManager.UpdateLives(lives);

        bool destroyed = lives <= 0;

        if (destroyed)
            FinishLevel(false);

        return destroyed;
    }
    public void EnemyDestroyed(int points)
    {
        enemiesInLevel--;
        levelScore += points;
        theUIManager.RemoveEnemy();
    }

    public void FinishLevel(bool playerWon)
    {
        if (playerWon)
        {
            Debug.Log("BIEN!!!");
            sessionScore += levelScore;
            theUIManager.Score(levelScore, sessionScore, stage, true);
            Invoke("NextScene", 3);
        }
        else
        {
            Debug.Log(":C");
            theUIManager.Score(0, 0, 0, false);
            Invoke("GameOver", 3);
        }
        enemiesInLevel = 0;
    }
    private void NextScene()
    {
        stage++;
        if (stage >= scenesInOrder.Length)
        {
            stage = 1;
            SceneManager.LoadScene(scenesInOrder[0]);
        } 
        else
            SceneManager.LoadScene(scenesInOrder[stage]);
    }

    private void GameOver()
    {
        stage = 1;
        SceneManager.LoadScene(scenesInOrder[0]);
    }

    private void Update()
    {
        Debug.Log(stage);
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void AddEnemy()
    {
        enemiesInLevel++;
        if (theUIManager != null) //Por como funcionan los starts puede pasar que haga primero el del UIManager
            theUIManager.Init(lives, enemiesInLevel);
    }

    public void SetUIManager (UIManager uim)
    {
        theUIManager = uim;
        uim.Init(lives, enemiesInLevel);
    }
}
