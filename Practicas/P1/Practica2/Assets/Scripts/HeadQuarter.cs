
using UnityEngine;

public class HeadQuarter : MonoBehaviour
{
    public Sprite destroyed_sprite;

    private SpriteRenderer sprite; //sprite renderer del objeto en cuestion
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
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
            sprite.sprite = destroyed_sprite;
        }
        GameManager.getInstance().FinishLevel(b == null);
    }
}
