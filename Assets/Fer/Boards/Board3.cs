using UnityEngine;

public class Board3 : MonoBehaviour
{
    public bool rojo3 = false;
    public bool azul3 = false;

    void Start()
    {
        rojo3 = false;
        azul3 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul3 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo3 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul3 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo3 = false;
        }
    }
}
