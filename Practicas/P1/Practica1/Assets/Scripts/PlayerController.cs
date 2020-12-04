using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public const float ANCHO_MUNDO = 13f; //ancho del mundo
    public float units_per_secs = 5; //unidades que se mueve el objeto
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // pillamos el input

        if (x > 0 && (transform.position.x) < ANCHO_MUNDO/2 || x < 0 && transform.position.x > -ANCHO_MUNDO/2)
        {
            transform.Translate(new Vector3( x * units_per_secs * Time.deltaTime, 0, 0 )); //movemos el objeto
        }
    }
}
