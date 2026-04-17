using UnityEngine;
public class Phantom : Enemy, IDamageable, IDetect
{
    // Atributo
    private bool isVisible;
    private float detectionRange;


    // Constructor
    public Phantom(string name, int health, bool isVisible, float detectionRange)
        : base(name, health)
    {
        this.isVisible = isVisible;
        this.detectionRange = detectionRange;
    }

    // Implementación de Enemy 

    public override void Attack()
    {
        if (isVisible)
        {
            Debug.Log("¡" + Name + " ataca desde la sombra!");
        }
        else
        {
            Debug.Log("¡" + Name + " está invisible, no puede atacar ahora.");
        }
    }

    protected override void OnPlayerEnter(Collider2D other)
    {
        DetectPlayer();
        GettingDetectionRange();
        IsVisiblePhantom(true);
    }

    // Implementación de IDamageable 

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("¡" + Name + " recibió " + damage + " de daño. Vida restante: " + health);

        if(health <= 0)
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
        Debug.Log("¡" + Name + " detecta al jugador sigilosamente...");
        IsVisiblePhantom(true);
        return isVisible == true;
    }

    public float GettingDetectionRange()
    {
        if (isVisible)
        {
            Debug.Log("Fantasmin detectó al jugador en un rango de: " + detectionRange);
                return detectionRange;
        }
        else
        {
            Debug.Log("Fantasmin esta buscando al jugador en un rango de: " + detectionRange);
            return detectionRange;
        }
    }


    //Getter y setter
    public float DetectionRange
    {
        get { return detectionRange; }
        set { detectionRange = value; }
    }

    //metodo unico de Phantom
    public void IsVisiblePhantom(bool status)
    {
        if (status == true)
        {
            spriteRenderer.enabled = true;
            isVisible = true;
        }
        else
        {
            spriteRenderer.enabled = false;
            isVisible = false;
        }
    }

    public bool IsVisible
    {
        get { return isVisible; }
        set { isVisible = value; }
    }

}
