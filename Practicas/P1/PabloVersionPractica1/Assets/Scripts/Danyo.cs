using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danyo : MonoBehaviour
{
    Camera camara;
    float danyoPercent = 0;
    float timer = 1;

    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (danyoPercent > 0) danyoPercent -= 1;
            timer = 1;
        }
        camara.backgroundColor = new Color(danyoPercent / 100, danyoPercent / 100, danyoPercent / 100);
    }

    public void lostLetter()
    {
        if(danyoPercent < 100) danyoPercent += 10;
    }
}
