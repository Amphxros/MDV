
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocityScale;
   
    void Update()
    {
        transform.Translate(0, velocityScale * Time.deltaTime, 0);
    }
}
