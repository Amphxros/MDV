using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cae : MonoBehaviour
{
    public float min_vel;
    public float max_vel;

    private float units_per_second; 

    void Start()
    {
        if (min_vel < max_vel)
        {
            units_per_second = Random.Range(min_vel, max_vel);
        }
        
    }

    void Update()
    {
        transform.Translate (new Vector3(0, -units_per_second * Time.deltaTime, 0));
    }
}
