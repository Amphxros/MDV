
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(this.gameObject); 
    }
}
