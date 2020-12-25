using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocityScale;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, velocityScale * Time.deltaTime, 0);
    }
}
