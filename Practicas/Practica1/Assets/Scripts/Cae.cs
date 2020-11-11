using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cae : MonoBehaviour
{
    public float units_per_second = 1f;     
 
    void Update()
    {
        transform.Translate (new Vector3(0, -units_per_second * Time.deltaTime, 0));
    }
}
