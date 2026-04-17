using UnityEngine;
public class Snitch : Enemy, IDamageable, IDetect
{
    // Atributos
    private float volumeAlert;
    private float alertRadius;

    // Constructor 
    public Snitch(string name, int health, float volumeAlert, float alertRadius)
        : base(name, health)
    {
        this.volumeAlert = volumeAlert;
        this.alertRadius = alertRadius;
    }

    // Implementación de Enemy 

    public override void Attack()
    {
        Debug.Log("¡" + Name + " ataca alertando a otros enemigos!");
    }

    protected override void OnPlayerEnter(Collider2D collider2D)
    {
        DetectPlayer();
        GettingDetectionRange();
    }

    // Implementación de IDamageable
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("¡" + Name + " recibió: " +damage +" de daño. Vida restante: "+health);

        if (health <= 0)
        {
            Debug.Log(name + " Ha muerto");
            IsAlive(false);
        }
    }

    public float GettingHealth()
    {
        return health;
    }

    public bool IsAlive(bool status)
    {
        if (health > 0)
        {
            return true;
        }
        else
        {
            Destroy(gameObject);
            return false;
        }     
    }

    // Implementación de IDetectable

    public bool DetectPlayer()
    {
        Debug.Log("¡" + Name + " intenta detectar al jugador con radio " + alertRadius);
        return true;
    }

    public float GettingDetectionRange()
    {
        return alertRadius;
    }

    // Metodos unico de Snitch
    public void Alert()
    {
        Debug.Log("¡" + Name + " lanza una alerta con volumen" + volumeAlert +"!");
    }


    

    // Getters y setters
    public float VolumeAlert
    {
        get { return volumeAlert; }
        set { volumeAlert = value; }
    }

    public float AlertRadius
    {
        get { return alertRadius; }
        set { alertRadius = value; }
    }

}
