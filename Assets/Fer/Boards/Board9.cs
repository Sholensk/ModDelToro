using UnityEngine;

public class Board9 : MonoBehaviour
{
    public bool rojo9 = false;
    public bool azul9 = false;

    void Start()
    {
        rojo9 = false;
        azul9 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul9 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo9 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul9 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo9 = false;
        }
    }
}
