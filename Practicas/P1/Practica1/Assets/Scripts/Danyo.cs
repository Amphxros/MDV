using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danyo : MonoBehaviour
{
    float percent_=1, timer_=1;

    private Camera cam_; //camara
    
    void Start()
    {
        cam_ = Camera.main;
    }

    void Update()
    {
        timer_ -= Time.deltaTime;
        if (timer_ <= 0)
        {
            if (percent_ > 0) percent_ -= 1;

            timer_ = 1;
        }
        cam_.backgroundColor = new Color(percent_ / 100, percent_ / 100, percent_ / 100);
    }

    //metodo que aumenta el daño en caso de perder 1 letra
    public void OnLostLetter()
    {
        if (percent_ < 100)
        {
            percent_ += 10;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
