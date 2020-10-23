using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform north, south, west, east;

    float incX=0.1f, incZ=0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x < east.position.x || this.transform.position.x > west.position.x)
            incX = -incX;
        if (this.transform.position.z < north.position.z || this.transform.position.z > south.position.z)
            incZ = -incZ;

        this.transform.Translate(incX, 0, incZ);

    }
}
