using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    private void Start()
    {
        target = target.GetComponent<Transform>();
        offset = this.transform.position - target.transform.position;

    }
    void LateUpdate()
    {
        transform.position = target.position + offset;
            
     }
}
