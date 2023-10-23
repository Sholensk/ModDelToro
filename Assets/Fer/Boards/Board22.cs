using UnityEngine;

public class Board22 : MonoBehaviour
{
    public bool rojo22 = false;
    public bool azul22 = false;

    void Start()
    {
        rojo22 = false;
        azul22 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul22 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo22 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul22 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo22 = false;
        }
    }
}
