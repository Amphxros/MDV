using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private Danyo d;
    void Start()
    {
        d = GetComponent<Danyo>();
    }
   void OnTriggerEnter2D(Collider2D col)
   {
        Destroy(col.gameObject);
      
        if (d != null) //en el caso del player al coger las letras será nulo asi que no ejecutara esto
            d.OnLostLetter();
   }
}
