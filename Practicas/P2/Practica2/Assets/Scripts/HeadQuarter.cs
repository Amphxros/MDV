
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
        PlayerController p = col.gameObject.GetComponent<PlayerController>();
        if (p != null) //si ha llegado el jugador
        {
            print("Has ganado");
        }
        else
        {
            print("Has perdido");
            sprite.sprite = destroyed_sprite;
        }
        GameManager.getInstance().FinishLevel(p != null);

        Destroy(col.gameObject.GetComponent<Shooter>()); //y desactivamos los disparos
    }
}
