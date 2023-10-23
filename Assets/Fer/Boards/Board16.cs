using UnityEngine;

public class Board16 : MonoBehaviour
{
    public bool rojo16 = false;
    public bool azul16 = false;

    void Start()
    {
        rojo16 = false;
        azul16 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul16 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo16 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul16 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo16 = false;
        }
    }
}
