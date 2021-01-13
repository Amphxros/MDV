using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadQuarter : MonoBehaviour
{
    public Sprite destroyed_sprite;

    private SpriteRenderer renderer;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Bullet b = col.gameObject.GetComponent<Bullet>();
        if (b == null) //si ha llegado el jugador
        {
            print("Has ganado");
        }
        else
        {
            print("Has perdido");
            renderer.sprite = destroyed_sprite;
        }
    }
}
