using UnityEngine;

public class Board19 : MonoBehaviour
{
    public bool rojo19 = false;
    public bool azul19 = false;

    void Start()
    {
        rojo19 = false;
        azul19 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul19 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo19 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul19 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo19 = false;
        }
    }
}
