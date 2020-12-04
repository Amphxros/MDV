using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cae : MonoBehaviour
{
    public float minVel, maxVel;
    float unitPerSeconds;
    Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        tf = transform;
        unitPerSeconds = -Random.Range(minVel, maxVel);
    }

    // Update is called once per frame
    void Update()
    {
        tf.Translate(0, unitPerSeconds * Time.deltaTime, 0);
    }
}
