using UnityEngine;

public class Board25 : MonoBehaviour
{
    public bool rojo25 = false;
    public bool azul25 = false;

    void Start()
    {
        rojo25 = false;
        azul25 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul25 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo25 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul25 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo25 = false;
        }
    }
}
