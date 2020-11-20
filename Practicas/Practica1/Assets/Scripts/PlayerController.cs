using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float units_per_secs = 5;
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        //if( . . . ) //comprobar posicion actual dentro de los limites 
        transform.Translate(new Vector3(x * units_per_secs * Time.deltaTime,0, 0));
    }
}
