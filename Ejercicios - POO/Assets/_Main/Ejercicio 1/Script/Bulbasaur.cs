using UnityEngine;

public class Bulbasaur : Pokemon
{
    public Bulbasaur()
    {
        Nombre = "Bulbasaur";
        Vida = 130;
        Daño = 15;
    }

    public override void Atacar(Pokemon objetivo)
    {
        int dañoEspecial = Daño + 5;

        objetivo.Vida -= dañoEspecial;

        Debug.Log(Nombre + " hizo " + dañoEspecial +
                  " de daño a " + objetivo.Nombre +
                  ". Vida restante: " + objetivo.Vida);
    }
}
