using UnityEngine;

public class Pikachu : Pokemon
{
    public Pikachu()
    {
        Nombre = "Pikachu";
        Vida = 100;
        Daño = 20;
    }

    public override void Atacar(Pokemon objetivo)
    {
        int dañoEspecial = Daño + 10;

        objetivo.Vida -= dañoEspecial;

        Debug.Log(Nombre + " hizo " + dañoEspecial +
                  " de daño a " + objetivo.Nombre +
                  ". Vida restante: " + objetivo.Vida);
    }
}
