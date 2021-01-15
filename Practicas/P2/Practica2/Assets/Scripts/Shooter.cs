
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject prefab;  //objeto a instanciar
    public bool autoshoot = false; //si disparas automaticamente o por input
    public float coolingDownSecs, shootCadenceSecs; //coolingDownSecs y cadencia
    

    private Transform tr_; //transform del padre
    private float time_; 
    void Start()
    {
        time_ = coolingDownSecs;
        tr_ = GetComponentInParent<Transform>();

        if (autoshoot)
            InvokeRepeating("Shoot",0, shootCadenceSecs); 
    }
   void Update()
   {
        time_ -= Time.deltaTime;    
   }
    void OnDestroy()
    {
        CancelInvoke();
    }
   public void Shoot()
   {
        if (time_ <= 0)
        {
            Instantiate(prefab, transform.position, tr_.rotation); //instanciamos el objeto
            time_ = coolingDownSecs;
        }
    }
}
