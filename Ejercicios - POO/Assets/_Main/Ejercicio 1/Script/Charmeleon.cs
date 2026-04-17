using UnityEngine;

public class Charmeleon : Pokemon
{
    public Charmeleon()
    {
        Nombre = "Charmeleon";
        Vida = 120;
        Daño = 25;
    }

    public override void Atacar(Pokemon objetivo)
    {
        int dañoEspecial = Daño + 15;

        objetivo.Vida -= dañoEspecial;

        Debug.Log(Nombre + " hizo " + dañoEspecial +
                  " de daño a " + objetivo.Nombre +
                  ". Vida restante: " + objetivo.Vida);
    }
}