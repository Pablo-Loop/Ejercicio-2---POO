using UnityEngine;

public class MenuSeleccionPokemon : MonoBehaviour
{
    public Pikachu pikachu;
    public Charmeleon charmeleon;
    public Bulbasaur bulbasaur;
    public Bulbasaur EnemyBulbasaur;

    private Pokemon jugadorSeleccionado;

    void Start()
    {
        Debug.Log("Evita a ese BULBASAUR!, Selecciona tu Pokémon:");
        Debug.Log("1 - Pikachu");
        Debug.Log("2 - Charmeleon");
        Debug.Log("3 - Bulbasaur");


        pikachu.gameObject.SetActive(false);
        charmeleon.gameObject.SetActive(false);
        bulbasaur.gameObject.SetActive(false);

    }

    void Update()
    {
        if (jugadorSeleccionado == null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                jugadorSeleccionado = pikachu;
                pikachu.gameObject.SetActive(true);

                Debug.Log("Elegiste a Pikachu!");
                Debug.Log("Atacalo con tu movimiento especial");
                Debug.Log("Presiona espacio para atacar");

            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                jugadorSeleccionado = charmeleon;
                charmeleon.gameObject.SetActive(true);

                Debug.Log("Elegiste a Charmeleon!");
                Debug.Log("Atacalo con tu movimiento especial");
                Debug.Log("Presiona espacio para atacar");
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                jugadorSeleccionado = bulbasaur;
                bulbasaur.gameObject.SetActive(true);

                Debug.Log("Elegiste a Bulbasaur!");
                Debug.Log("Atacalo con tu movimiento especial");
                Debug.Log("Presiona espacio para atacar");
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jugadorSeleccionado.Atacar(EnemyBulbasaur);

                if (EnemyBulbasaur.Vida <= 10)
                {
                    Debug.Log("¡¡¡Derrotaste a BULBASAUR!!!");
                    bulbasaur.gameObject.SetActive(false);

                }
            }
        }
    }
}