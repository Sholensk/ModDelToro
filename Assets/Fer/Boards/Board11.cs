using UnityEngine;

public class Board11 : MonoBehaviour
{
    public bool rojo11 = false;
    public bool azul11 = false;

    [SerializeField] bool active = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rojo11 = false;
        azul11 = false;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo11 == false && azul11 == false)
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
            Color amarillo = new Color(0.9568f, 0.9960785f, 0.3098039f, 1f);
            spriteRenderer.color = amarillo;
        }

        if (collision.CompareTag("Rojo") && active == false)
        {
            Color morado = new Color(.5647f, .2f, .5019f, 1f);
            spriteRenderer.color = morado;
        }

        if (collision.CompareTag("CheckA"))
        {
            azul11 = true;
            rojo11 = false;
            active = true;
            Color amarillo = new Color(0.9568f, 0.9960785f, 0.3098039f, 1f);
            spriteRenderer.color = amarillo;
        }

        if (collision.CompareTag("CheckR"))
        {
            azul11 = false;
            rojo11 = true;
            active = true;
            Color morado = new Color(.5647f, .2f, .5019f, 1f);
            spriteRenderer.color = morado;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul") && active == false)
        {
            Color white = new Color(1f, 1f, 1f, 0f);
            spriteRenderer.color = white;
        }

        if (collision.CompareTag("Rojo") && active == false)
        {
            Color white = new Color(1f, 1f, 1f, 0f);
            spriteRenderer.color = white;
        }
    }
}
