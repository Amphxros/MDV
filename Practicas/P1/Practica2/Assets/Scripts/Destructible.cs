using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
   
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            Damageable d = this.gameObject.GetComponent<Damageable>();
            if (d!=null)
            {
                d.MakeDamage();
                if (d.getDamage() <= 0) //si es un enemigo con 0 de vida o es un bloque (no tienen vida asi que d=null)
                {
                    Destroy(this.gameObject);
                }
            }
            else
            {
                Destroy(this.gameObject);
            }
            
        }
    }
}
