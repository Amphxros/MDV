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
                if (d.getDamage() <= 0) //si es un "personaje" con 0 de vida o es un bloque (no tienen vida asi que d=null)
                {
                    PlayerController p = this.gameObject.GetComponent<PlayerController>(); //para diferenciar del enemigo y el jugador
                    if (p != null && !GameManager.getInstance().PlayerDestroyed()) //si existe este componente entonces es un jugador asi que reseteamos su posicion
                    {
                        p.ResetPosition();
                        d.ResetDamage(); 
                    }
                    else //si no es un enemigo con 0 de vida o el player tiene 0 de vida
                    {
                        Destroy(this.gameObject);
                    }
                }
            }
            else
            {
                Destroy(this.gameObject);
            }
            
        }
    }
}
