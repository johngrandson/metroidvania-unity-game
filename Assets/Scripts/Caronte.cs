using UnityEngine;

public class Caronte : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed = 2f;
    public GameObject[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveRight();
    }

    private void MoveRight()
    {
        rb.velocity = new Vector2(moveSpeed, 0);
        foreach (GameObject sprite in sprites)
        {
            SpriteRenderer spriteRenderer = sprite.GetComponent<SpriteRenderer>();
            spriteRenderer.flipX = true;
        }
    }

    private void MoveLeft()
    {
        rb.velocity = new Vector2(-moveSpeed, 0);
        foreach (GameObject sprite in sprites)
        {
            SpriteRenderer spriteRenderer = sprite.GetComponent<SpriteRenderer>();
            spriteRenderer.flipX = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RightBoundary"))
        {
            MoveLeft();
        }
        else if (collision.gameObject.CompareTag("LeftBoundary"))
        {
            MoveRight();
        }
    }
}
