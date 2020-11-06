using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate<GameObject>(cube); 
    }

    // Update is called once per frame
    void Update()
    {
    }
}
