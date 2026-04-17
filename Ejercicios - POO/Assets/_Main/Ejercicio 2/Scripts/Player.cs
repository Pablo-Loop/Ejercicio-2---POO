using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private Rigidbody2D rb2d;
    private float xMove;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb2d.linearVelocity = new Vector2(xMove * speed, rb2d.linearVelocity.y);
    }
}
