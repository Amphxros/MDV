using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovementWithLimits : MonoBehaviour
{
    public float topeDerecho;
    public float topeIzquierdo;

    float incX = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        if (topeIzquierdo > topeDerecho)
            Debug.LogError("cambia los limites");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > topeDerecho || this.transform.position.x < topeIzquierdo)
        {
            incX = -incX;
        }

        this.transform.Translate(incX, 0, 0);

    }
}
