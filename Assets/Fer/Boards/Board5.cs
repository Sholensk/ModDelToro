using UnityEngine;

public class Board5 : MonoBehaviour
{
    public bool rojo5 = false;
    public bool azul5 = false;

    void Start()
    {
        rojo5 = false;
        azul5 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul5 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo5 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul5 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo5 = false;
        }
    }
}
