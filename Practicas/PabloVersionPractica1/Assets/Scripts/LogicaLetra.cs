using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaLetra : MonoBehaviour
{
    TextMesh text;
    char c;
    int type; //0 = Min     1 = Mayus       2 = number
    int init, last;

    // Start is called before the first frame update
    void Start()
    {
        type = Random.Range(0, 2);
        if(type == 0)
        {
            init = 'a';
            last = 'z';
        }
        else if (type == 1)
        {
            init = 'A';
            last = 'Z';
        }
        else if (type == 2)
        {
            init = '0';
            last = '9';
        }
        c = (char)Random.Range(init, last);

        text = GetComponent<TextMesh>();
        text.text = c.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.inputString == c.ToString())
        {
            Destroy(gameObject);
        }
    }
}
