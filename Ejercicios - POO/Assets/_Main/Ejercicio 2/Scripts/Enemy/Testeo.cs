using UnityEngine;

public class Testeo : MonoBehaviour
{
    [Header("Configuración de Snitch")]
    [SerializeField] private float snitchAlertRadius;
    [SerializeField] private float snitchVolumeAlert;
    [SerializeField] private int snitchHealth;

    [Header("Configuración de Stalker")]
    [SerializeField] private float stalkerDetectionRange;
    [SerializeField] private float stalkerSpeed;
    [SerializeField] private int stalkerHealth;


    [Header("Configuración de Phantom")]
    [SerializeField] private float phantomDetectionRange;
    [SerializeField] private bool phantomIsVisible = false;
    [SerializeField] private int phantomHealth;


    //  Referencias internas 
    private Snitch snitch;
    private Stalker stalker;
    private Phantom phantom;

    [Header("Asignación de Prefabs de Enemigos")]
    [SerializeField] private GameObject snitchPrefab;
    [SerializeField] private GameObject stalkerPrefab;
    [SerializeField] private GameObject phantomPrefab;

    void Start()
    {
        CreateEnemySnitch(new Vector2(5, 2f));
        CreateEnemyStalker(new Vector2(-1, -3));
        CreateEnemyPhantom(new Vector2(-5, -2));

        Debug.Log("====== MENÚ PRINCIPAL ======" +
            "\n Selecciona una de las opciones para realizar" +
            "\n 1. Ataque de Snitch al jugador" +
            "\n 2. Ataque de Stalker al jugador" +
            "\n 3. Ataque de Phantom al jugador" +
            "\n 4. El jugador realizar un ataque a Snitch y a Phantom");

    }

    void Update()
    {
        // Teclas de prueba 

        // Ataque de snitch
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            snitch.Attack();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            stalker.Attack();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            phantom.Attack();
        }

        //  Daño a snitch y phantom
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("Hiciste daño al snitch y al Phantom");
            snitch.TakeDamage(25);
            phantom.TakeDamage(25);
        }
    }

    void CreateEnemySnitch(Vector3 posicion)
    {
        GameObject newSnitch = Instantiate(snitchPrefab, posicion, Quaternion.identity);
        newSnitch.name = "Snitch";

        snitch = newSnitch.GetComponent<Snitch>();

        snitch.Name = "El sapo";
        snitch.SetHealth(snitchHealth);
        snitch.VolumeAlert = snitchVolumeAlert;
        snitch.AlertRadius = snitchAlertRadius;
    }

    void CreateEnemyStalker(Vector3 posicion)
    {
        GameObject newStalker = Instantiate(stalkerPrefab, posicion, Quaternion.identity);
        newStalker.name = "Stalker";

        stalker = newStalker.GetComponent<Stalker>();

        stalker.Name = "El acosador";
        stalker.SetHealth(stalkerHealth);
        stalker.Speed = stalkerSpeed;
        stalker.DetectionRange = stalkerDetectionRange;

    }

    void CreateEnemyPhantom(Vector3 posicion)
    {
        GameObject newPhantom = Instantiate(phantomPrefab, posicion, Quaternion.identity);
        newPhantom.name = "Phantom";

        phantom = newPhantom.GetComponent<Phantom>();

        phantom.IsVisiblePhantom(false);
        phantom.Name = "Fantasmin";
        phantom.SetHealth(phantomHealth);
        phantom.DetectionRange = phantomDetectionRange;
        phantom.IsVisible = phantomIsVisible;
    }
}
