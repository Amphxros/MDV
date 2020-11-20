using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaLetra : MonoBehaviour
{
    private TextMesh text; //texto del go
    void Start()
    {
        //Generar random para asignar al texto

    }

    void Update()
    {
        string input = Input.inputString;
        if (input == text.text)
        {
            Destroy(this.gameObject);
        }
        
    }
}
