using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject prefab;
    public float coolingDownSecs; //coolingDownSecs
    private Transform tr_; //transform del padre
    private float time_;
    void Start()
    {
        time_ = coolingDownSecs;
        tr_ = GetComponentInParent<Transform>(); // obtenemos el transform del objeto padre
        Shoot(); //esto es para pruebas de momento
    }
   void Update()
   {
        time_ -= Time.time* Time.deltaTime;

   }
   public void Shoot()
   {
        if (time_ <= 0)
        {
            Instantiate(prefab, transform.position, tr_.rotation); //instanciamos el objeto
            time_ = Time.time + coolingDownSecs;
        }
    }
}
