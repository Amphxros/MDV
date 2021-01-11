using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Destructible>() != null)
            col.gameObject.GetComponent<Destructible>().remove();

        if (col.gameObject.GetComponent<Damageable>() != null)
            col.gameObject.GetComponent<Damageable>().MakeDamage();

        Destroy(gameObject);
    }
}
