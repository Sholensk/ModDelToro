using UnityEngine;

public class Board2 : MonoBehaviour
{
    public bool rojo2 = false;
    public bool azul2 = false;

    void Start()
    {
        rojo2 = false;
        azul2 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul2 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo2 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul2 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo2 = false;
        }
    }
}
