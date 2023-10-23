using UnityEngine;

public class Board17 : MonoBehaviour
{
    public bool rojo17 = false;
    public bool azul17 = false;

    void Start()
    {
        rojo17 = false;
        azul17 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul17 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo17 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul17 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo17 = false;
        }
    }
}
