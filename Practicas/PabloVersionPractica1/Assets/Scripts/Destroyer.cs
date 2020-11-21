using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    Danyo d;
    void Start()
    {
        d = GetComponent<Danyo>();
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        d.lostLetter();
    }

}
