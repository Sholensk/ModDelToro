using UnityEngine;

public class Board4 : MonoBehaviour
{
    public bool rojo4 = false;
    public bool azul4 = false;

    void Start()
    {
        rojo4 = false;
        azul4 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul4 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo4 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul4 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo4 = false;
        }
    }
}
