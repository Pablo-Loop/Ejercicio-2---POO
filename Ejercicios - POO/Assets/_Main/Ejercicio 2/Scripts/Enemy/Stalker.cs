using UnityEngine;
public class Stalker : Enemy, IDetect
{
    // Atributos
    private float speed;
    private float detectionRange;

    // Constructor
    public Stalker(string name, int health, float speed, float detectionRange)
        : base(name, health)
    {
        this.speed = speed;
        this.detectionRange = detectionRange;
    }

    // Implementación de Enemy 

    public override void Attack()
    {
        Debug.Log("¡" + this.name + " ataca rápidamente con velocidad " + speed +"!");
    }

    // Implementación de IDetectable 

    public bool DetectPlayer()
    {
        Debug.Log("¡" + this.name + " detecta al jugador en rango " + detectionRange);
        return true;
    }

    public float GettingDetectionRange()
    {
        return detectionRange;
    }

    protected override void OnPlayerEnter(Collider2D other)
    {
        DetectPlayer();
        GettingDetectionRange();
    }

    //Getter y setter
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public float DetectionRange
    {
        get { return detectionRange; }
        set { detectionRange = value; }
    }
}
