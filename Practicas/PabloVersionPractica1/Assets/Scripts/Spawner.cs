using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float minTime, maxTime;
    float spawTimer;
    Transform spawTf;
    float spawZone;
    // Start is called before the first frame update
    void Start()
    {
        spawTf = transform;
        spawTimer = Random.Range(minTime, maxTime);
        spawZone = spawTf.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        spawTimer -= Time.deltaTime;
        if(spawTimer <= 0)
        {
            Instantiate(prefab, new Vector3(Random.Range(-spawZone, spawZone), spawTf.position.y, spawTf.position.z), Quaternion.identity, spawTf);
            spawTimer = Random.Range(minTime, maxTime);
        }
    }
}
