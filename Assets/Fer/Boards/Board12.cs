using UnityEngine;

public class Board12 : MonoBehaviour
{
    public bool rojo12 = false;
    public bool azul12 = false;

    void Start()
    {
        rojo12 = false;
        azul12 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul12 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo12 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul12 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo12 = false;
        }
    }
}
