using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform transform_hour;    //Horas
    public Transform transform_min;     // minutos
    public Transform transform_sec;     //segundos

    const float DEGREES = -30f;    
    void Start()
    {
        print("I wanna die");
    }

    void Update()
    {
       int hour= DateTime.Now.Hour;
       int min = DateTime.Now.Minute;
       int sec = DateTime.Now.Second;

      // print(hour +":"+min+ ":"+sec);
        transform_hour.localRotation = Quaternion.Euler(0, DEGREES * hour,0);
        transform_min.localRotation = Quaternion.Euler(0, DEGREES/5 * min, 0);
        transform_sec.localRotation = Quaternion.Euler(0, DEGREES / 5 * sec, 0);

    }
}
