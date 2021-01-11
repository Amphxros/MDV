using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float coolingDownSeconds;
    public float shootCadenceSecs;
    public bool autoShoot;

    float spawTimer;
    Transform spawTf;

    // Start is called before the first frame update
    void Start()
    {
        spawTf = transform;
        spawTimer = coolingDownSeconds;
        if (autoShoot)
            InvokeRepeating("Shoot", 0, shootCadenceSecs);
    }
    
    // Update is called once per frame
    void Update()
    {
        spawTimer -= Time.deltaTime;
    }

    public void Shoot()
    {
        if (spawTimer <= 0)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = spawTf.position;
            bullet.transform.up = spawTf.up;
            spawTimer = coolingDownSeconds;
        }
    }

    void OnDestroy()
    {
        CancelInvoke();
    }
}
