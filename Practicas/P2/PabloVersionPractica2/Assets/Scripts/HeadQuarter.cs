using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadQuarter : MonoBehaviour
{
    public Sprite destroyedSprite;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            this.GetComponent<SpriteRenderer>().sprite = destroyedSprite;
            GameManager.GetInstance().FinishLevel(false);
        }

        if (col.gameObject.CompareTag("Player"))
            GameManager.GetInstance().FinishLevel(true);
    }
}
