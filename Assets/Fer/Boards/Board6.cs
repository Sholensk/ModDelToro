using UnityEngine;

public class Board6 : MonoBehaviour
{
    public bool rojo6 = false;
    public bool azul6 = false;

    void Start()
    {
        rojo6 = false;
        azul6 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul6 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo6 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul6 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo6 = false;
        }
    }
}
