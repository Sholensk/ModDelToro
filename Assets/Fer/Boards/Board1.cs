using UnityEngine;

public class Board1 : MonoBehaviour
{
    public bool rojo1 = false;
    public bool azul1 = false;

    void Start()
    {
        rojo1 = false;
        azul1 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul1 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo1 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul1 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo1 = false;
        }
    }
}
