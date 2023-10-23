using UnityEngine;

public class Board14 : MonoBehaviour
{
    public bool rojo14 = false;
    public bool azul14 = false;

    void Start()
    {
        rojo14 = false;
        azul14 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul14 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo14 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul14 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo14 = false;
        }
    }
}
