using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int max_damage; //daño maximo

    private int current_damage; //daño actual

    private Vector3 initialPos; //posicion inicial
    private Quaternion initialRot; //rotacion inicial

    private PlayerController p; //player controller para determinar si este objeto es un player

    void Start()
    {
        current_damage = max_damage;

        initialPos = this.transform.position;
        initialRot = this.transform.rotation;
        p = this.gameObject.GetComponent<PlayerController>();
    }

    /// <summary>
    /// Hace 1 de daño al objeto y resta vida si es necesario 
    /// </summary>
    public void MakeDamage()
    {
        current_damage--;

        if (current_damage <= 0)
        {
            if (p != null) //si no es null -> es un player
            {
                if (!GameManager.getInstance().PlayerDestroyed()) //si aun tiene vidas reseteamos la posicion y rotacion
                {
                    ResetPosition();
                }
                else //si no muere y perderiamos la partida
                {
                    Destroy(this.gameObject);
                    GameManager.getInstance().FinishLevel(false);
                }
            }
            else //si es null puede ser un enemigo
            {
                Enemy enemy = this.gameObject.GetComponent<Enemy>();
                GameManager.getInstance().EnemyDestroyed(enemy.points);
                Destroy(this.gameObject);
            }

            ResetDamage();

        }
    }

    //reseteamos el daño recibido
    void ResetDamage() { current_damage = max_damage; }
    
    //reseteamos la posicion
    void ResetPosition()
    {
        this.transform.position = initialPos;
        this.transform.rotation = initialRot;
    }
    //si colisiona nos hacemos daño
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Bullet>() != null)
        {
            MakeDamage();
        }
    }
}

