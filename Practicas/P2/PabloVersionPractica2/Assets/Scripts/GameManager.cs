using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField]
    private int score;
    [SerializeField]
    private int lives;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
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

        bool destroyed = lives <= 0;

        if (destroyed)
            FinishLevel(false);

        return destroyed;
    }
    public void EnemyDestroyed(int destructionPoints)
    {
        score += destructionPoints;
    }

    public void FinishLevel(bool playerWon)
    {
        if (playerWon)
            Debug.Log("BIEN!!!");
        else
            Debug.Log(":C");
                
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
