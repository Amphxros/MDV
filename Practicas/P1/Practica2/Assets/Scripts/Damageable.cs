using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int max_damage;

    private int current_damage;

    private Vector3 initialPos;
    private Quaternion initialRot;

    private PlayerController p;

    void Start()
    {
        current_damage = max_damage;

        initialPos = this.transform.position;
        initialRot = this.transform.rotation;
        p = this.gameObject.GetComponent<PlayerController>();
    }

    public void MakeDamage()
    {
        current_damage--;

        if (current_damage <= 0)
        {
            if (p != null)
            {
                if (!GameManager.getInstance().PlayerDestroyed())
                {
                    this.transform.position = initialPos;
                    this.transform.rotation = initialRot;
                }
                else
                {
                    Destroy(this.gameObject);
                }
            }
            else
            {
                Destroy(this.gameObject);
            }

            ResetDamage();

        }
    }
   void ResetDamage() { current_damage = max_damage; }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Bullet>() != null)
        {
            MakeDamage();
        }
    }
}
