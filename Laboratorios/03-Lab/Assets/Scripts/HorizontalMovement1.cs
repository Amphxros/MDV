using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement1 : MonoBehaviour
{
    float incX = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(this.transform.position.x>5 || this.transform.position.x < -5)
        {
            incX = -incX;
        }

        this.transform.Translate(incX, 0, 0);

    }
}
