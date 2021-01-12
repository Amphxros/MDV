using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Damageable : MonoBehaviour
{
    public int maxDamage;
    int actualDamage;
    //public int points;
    Vector2 positionPlayer;
    Quaternion rotationPlayer;
    bool isPlayer = false; //Para no estar comparando el tag

    void Start()
    {
        if (this.CompareTag("Player"))
        {
            positionPlayer = transform.position;
            rotationPlayer = transform.rotation;
            isPlayer = true;
        }
        actualDamage = maxDamage;
    }
    public void MakeDamage()
    {
        actualDamage--;
        if (actualDamage <= 0)
        {
            if (isPlayer)
            {
                if (GameManager.GetInstance().PlayerDestroyed())
                    Destroy(gameObject);
                else
                    transform.SetPositionAndRotation(positionPlayer, rotationPlayer);
            }
            else
            {
                //GameManager.GetInstance().EnemyDestroyed(points);
                Destroy(gameObject);
            }
            actualDamage = maxDamage;
        }
    }

}
