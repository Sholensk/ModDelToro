using UnityEngine;

public class Board20 : MonoBehaviour
{
    public bool rojo20 = false;
    public bool azul20 = false;

    void Start()
    {
        rojo20 = false;
        azul20 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul20 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo20 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul20 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo20 = false;
        }
    }
}
