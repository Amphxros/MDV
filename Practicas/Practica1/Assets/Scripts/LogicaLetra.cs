using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaLetra : MonoBehaviour
{
    private TextMesh text; //texto del go
    void Start()
    {
        text = GetComponent<TextMesh>();
        char c  = (char)(Random.Range(65, 91));  //mayusculas
        text.text = c.ToString();
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
