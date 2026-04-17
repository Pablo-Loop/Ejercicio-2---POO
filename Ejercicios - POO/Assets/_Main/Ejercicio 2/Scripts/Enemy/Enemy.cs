using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    // Atributos 
    protected string name;
    protected int health;
    [SerializeField] protected SpriteRenderer spriteRenderer;

    // Constructor
    public Enemy(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    // Métodos 
    public void Walking()
    {
        Debug.Log(name + " está caminando.");
    }

    public void FollowingPlayer()
    {
        Debug.Log(name + " está siguiendo al jugador.");
    }

    public abstract void Attack();

    protected virtual void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            OnPlayerEnter(collider2D); 
        }
    }

    protected abstract void OnPlayerEnter(Collider2D collider2D);

    public int GetHealth()
    {
        return health;
    }
    public void SetHealth(int value)
    {
        health = Mathf.Max(0, value);
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
