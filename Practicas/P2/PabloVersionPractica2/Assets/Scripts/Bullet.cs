using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int velocityScale;
    Transform tf;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        tf = transform;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = tf.up * velocityScale;
    }
}
