using UnityEngine;

public class Board23 : MonoBehaviour
{
    public bool rojo23 = false;
    public bool azul23 = false;

    void Start()
    {
        rojo23 = false;
        azul23 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul23 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo23 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul23 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo23 = false;
        }
    }
}
