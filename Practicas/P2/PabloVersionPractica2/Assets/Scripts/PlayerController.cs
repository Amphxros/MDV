using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int velocityScale;
    Transform tf;
    Rigidbody2D rb;
    float deltaX, deltaY;

    // Start is called before the first frame update
    void Start()
    {
        tf = transform;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //////////////////////////////////////////////////////////////
                                //ESCENA 01//
        //////////////////////////////////////////////////////////////
        deltaX = Input.GetAxis("Horizontal") * velocityScale;
        deltaY = Input.GetAxis("Vertical") * velocityScale;
        
        if(deltaY != 0)
        {
            if (deltaY > 0)
                tf.up = Vector2.up;
            else
                tf.up = Vector2.down;
            rb.velocity = new Vector2(0, deltaY * velocityScale);
        }
        else
        {
            if (deltaX > 0)
                tf.up = Vector2.right;
            else if (deltaX < 0)
                tf.up = Vector2.left;
            rb.velocity = new Vector2(deltaX * velocityScale, 0);
        }

        //////////////////////////////////////////////////////////////
                                //ESCENA 02//
        //////////////////////////////////////////////////////////////
        if (Input.GetButton("Jump"))
            GetComponentInChildren<Shooter>().Shoot();
    }
}
