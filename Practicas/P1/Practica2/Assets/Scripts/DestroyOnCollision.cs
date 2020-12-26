using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
   void OnCollision2DEnter(Collision2D col)
    {
        Destroy(this.gameObject);
    }
}
