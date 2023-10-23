using UnityEngine;

public class Board15 : MonoBehaviour
{
    public bool rojo15 = false;
    public bool azul15 = false;

    void Start()
    {
        rojo15 = false;
        azul15 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul15 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo15 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul15 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo15 = false;
        }
    }
}
