using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int max_damage;

    private int current_damage;

    void Start()
    {
        current_damage = max_damage;
    }

    public void MakeDamage()
    {
        current_damage--;
    }
    public int getDamage() { return current_damage; }

    public void ResetDamage() { current_damage = max_damage; }
}
