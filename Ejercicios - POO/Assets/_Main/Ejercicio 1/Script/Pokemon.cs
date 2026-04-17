using UnityEngine;

public class Pokemon : MonoBehaviour
{
    // ENCAPSULAMIENTO
    private string nombre;
    private int vida;
    private int daño;

    // Getter y Setter
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Vida
    {
        get { return vida; }
        set
        {
            if (value >= 0)
            {
                vida = value;
            }
            else
            {
                Debug.Log("Pokemon Derrotado");
            }
        }
    }

    public int Daño
    {
        get { return daño; }
        set
        {
            if (value > 0)
            {
                daño = value;
            }
        }
    }

    public virtual void Atacar(Pokemon objetivo)
    {
        objetivo.Vida -= Daño;

        Debug.Log(Nombre + " hizo " + Daño +
                  " de daño a " + objetivo.Nombre +
                  ". Vida restante de " + objetivo.Nombre +
                  ": " + objetivo.Vida);
    }
}