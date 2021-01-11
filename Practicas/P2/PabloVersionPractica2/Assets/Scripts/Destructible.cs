using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public void remove()
    {
        Destroy(gameObject);
    }
}
