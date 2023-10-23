using UnityEngine;

public class Board18 : MonoBehaviour
{
    public bool rojo18 = false;
    public bool azul18 = false;

    void Start()
    {
        rojo18 = false;
        azul18 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul18 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo18 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul18 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo18 = false;
        }
    }
}
