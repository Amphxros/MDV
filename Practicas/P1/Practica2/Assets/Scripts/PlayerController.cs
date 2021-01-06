using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocityScale;
    
    private Rigidbody2D rb;
    private Shooter shoot;

    private Vector3 initialPos;
    private Quaternion initialRot;
    void Start()
    {
      
        initialPos = this.transform.position;
        initialRot = this.transform.rotation;

        rb = GetComponent<Rigidbody2D>();//pillamos el rigidbody
        shoot = GetComponentInChildren<Shooter>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");  //pillamos el input horizontal
        float y = Input.GetAxis("Vertical");    //pillamos el input vertical

        //por defecto si pulsas dos teclas de ejes distintos se movera en el eje X
        if (x > 0) //movimiento hacia la derecha
        {
            transform.up = Vector2.right;
            rb.velocity = new Vector2(x * velocityScale,0);

        }
        else if (x < 0)//movimiento hacia la izquierda
        {
            transform.up = Vector2.left;
            rb.velocity = new Vector2( x * velocityScale, 0);

        }
        else if (y < 0)//movimiento hacia abajo
        {
            transform.up = Vector2.down;
            rb.velocity = new Vector2(0, y * velocityScale);

        }
        else if (y > 0)//movimiento hacia arriba
        {
            transform.up = Vector2.up;
            rb.velocity = new Vector2(0, y* velocityScale);
        }

        if (Input.GetButton("Jump"))
        {
            shoot.Shoot();
        }

    }

    public void ResetPosition()
    {
        this.transform.position = initialPos;
        this.transform.rotation = initialRot;
    }
}
