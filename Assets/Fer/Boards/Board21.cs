using UnityEngine;

public class Board21 : MonoBehaviour
{
    public bool rojo21 = false;
    public bool azul21 = false;

    void Start()
    {
        rojo21 = false;
        azul21 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul21 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo21 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul21 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo21 = false;
        }
    }
}
