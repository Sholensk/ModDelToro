using UnityEngine;

public class Board24 : MonoBehaviour
{
    public bool rojo24 = false;
    public bool azul24 = false;

    [SerializeField] bool active = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rojo24 = false;
        azul24 = false;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo24 == false && azul24 == false)
        {
            active = false;
        }

        else
        {
            active = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul") && active == false)
        {
            spriteRenderer.color = Color.blue;
        }

        if (collision.CompareTag("Rojo") && active == false)
        {
            spriteRenderer.color = Color.red;
        }

        if (collision.CompareTag("CheckA"))
        {
            azul24 = true;
            rojo24 = false;
            active = true;
            spriteRenderer.color = Color.blue;
        }

        if (collision.CompareTag("CheckR"))
        {
            azul24 = false;
            rojo24 = true;
            active = true;
            spriteRenderer.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul") && active == false)
        {
            spriteRenderer.color = Color.white;
        }

        if (collision.CompareTag("Rojo") && active == false)
        {
            spriteRenderer.color = Color.white;
        }
    }
}
