using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;   //objeto a instaanciar(letra en este caso)
    public float min_time;      //tiempo min de spawn
    public float max_time;      //tiempo max de spawn

    private Collider2D col;
    private float limite_;
    void Start()
    {
        col = GetComponent<Collider2D>();
        limite_=col.bounds.size.x; //ancho del collider
        float time_ = Random.Range(min_time, max_time);
        Invoke("Spawn", time_);
    }
    void Spawn()
    {
        float time_ = Random.Range(min_time, max_time);
        float pos = Random.Range(-limite_ / 2, limite_ / 2);

        Instantiate(prefab, new Vector3(pos, transform.position.y, 0), Quaternion.identity);
        Invoke("Spawn",time_);
    }
}
