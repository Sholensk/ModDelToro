using UnityEngine;

public class Board22 : MonoBehaviour
{
    public bool rojo22 = false;
    public bool azul22 = false;

    [SerializeField] bool active = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rojo22 = false;
        azul22 = false;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo22 == false && azul22 == false)
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
