using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{ 
    void Update()
    {
        this.transform.Translate(0.1f, 0, 0);
    }
}
