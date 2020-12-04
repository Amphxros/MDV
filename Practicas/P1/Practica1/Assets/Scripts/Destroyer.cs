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
        Destroy(col.gameObject); //destruimos el objeto que entra en el trigger
      
        d.OnLostLetter(); //se ejecuta en cas de que exista el componente
   }
}
