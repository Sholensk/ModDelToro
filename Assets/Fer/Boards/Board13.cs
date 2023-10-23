using UnityEngine;

public class Board13 : MonoBehaviour
{
    public bool rojo13 = false;
    public bool azul13 = false;

    void Start()
    {
        rojo13 = false;
        azul13 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul13 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo13 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul13 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo13 = false;
        }
    }
}
