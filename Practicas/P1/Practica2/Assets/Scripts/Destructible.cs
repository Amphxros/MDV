using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{


    void OnCollisionEnter2D(Collision2D col)
    {
        Bullet b = col.gameObject.GetComponent<Bullet>();
        if (b != null)
        {
            Destroy(this.gameObject);
        }
        
    }
}
