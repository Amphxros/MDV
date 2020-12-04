using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaeFisico : MonoBehaviour
{
    public float min_vel;
    public float max_vel;

    private float units_per_second;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (min_vel < max_vel)
        {
            units_per_second = Random.Range(min_vel, max_vel);
        }
    }

    void Update()
    {
        rb.velocity= new Vector2(0, -units_per_second);
    }
}
