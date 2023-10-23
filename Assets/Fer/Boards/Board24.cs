using UnityEngine;

public class Board24 : MonoBehaviour
{
    public bool rojo24 = false;
    public bool azul24 = false;

    void Start()
    {
        rojo24 = false;
        azul24 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul24 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo24 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul24 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo24 = false;
        }
    }
}
