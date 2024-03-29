﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaLetra : MonoBehaviour
{
    private TextMesh text; //texto del gameObject
    int type, init, last; //tipo de char inicio y final
    void Start()
    {
        text = GetComponent<TextMesh>();
        
        type = Random.Range(0, 3); //random entre [a,b) es decir excluye el maximo
        
        if (type == 0)  //caso minusculas
        {
            init = 'a';
            last = 'z';
        }
        else if (type == 1) //caso mayusculas
        {

            init = 'A';
            last = 'Z';
        }
        else       //caso numeros
        {
            init = '0';
            last = '9';
        }

        char c  = (char)(Random.Range(init, last)); //generamos un char entre el rango correspondiente   
        text.text = c.ToString(); //lo asignamos al texto
    }

    void Update()
    {
        string input = Input.inputString; //pillamos el input
        if (input == text.text) //y si coincide con el texto se destruye
        {
            Destroy(this.gameObject);
        }
        
    }
}
