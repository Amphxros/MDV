using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float units_per_secs = 5; //unidades que se mueve el objeto

    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // pillamos el input

        if (x > 0 && transform.position.x < 6.5 || x < 0 && transform.position.x > -6.5)
        {
            transform.Translate(new Vector3( x * units_per_secs * Time.deltaTime, 0, 0 )); //movemos el objeto
        }
    }
}
