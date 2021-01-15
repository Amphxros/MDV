
using UnityEngine;

public class Destructible : MonoBehaviour
{
    //destruimos el objeto si colisionamos con una bala
    void OnCollisionEnter2D(Collision2D col)
    {
        Bullet b = col.gameObject.GetComponent<Bullet>();
        if (b != null)
        {
            Destroy(this.gameObject);
        }
        
    }
}
