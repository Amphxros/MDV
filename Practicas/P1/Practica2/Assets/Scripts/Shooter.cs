using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject prefab;
    public float coolingDownSecs; //coolingDownSecs
    private Transform tr_; //transform del padre
    void Start()
    {
        tr_ = GetComponentInParent<Transform>(); // obtenemos el transform del objeto padre
        Shoot(); //esto es para pruebas de momento
    }

   
   public void Shoot()
   {
       Instantiate(prefab, transform.position,tr_.rotation); //instanciamos el objeto
       Invoke("Shoot", coolingDownSecs); //esto es para pruebas de momento
    }
}
