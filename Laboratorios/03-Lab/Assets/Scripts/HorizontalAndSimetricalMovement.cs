using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalAndSimetricalMovement : MonoBehaviour
{
    float incX = 0.2f;
    public float tope;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > tope || this.transform.position.x < -tope)
        {
            incX = -incX;
        }

        this.transform.Translate(incX, 0, 0);

    }
}
