using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float unitPerSecond;
    const float BORDE = 6.5f;
    Transform tf;
    float delta;

    // Start is called before the first frame update
    void Start()
    {
        tf = transform;
    }

    // Update is called once per frame
    void Update()
    {
        delta = Input.GetAxis("Horizontal") * unitPerSecond;
        if((delta > 0 && tf.position.x < BORDE) ||
           (delta < 0 && tf.position.x > -BORDE)) tf.Translate(delta * Time.deltaTime, 0, 0);
    }
}
