using UnityEngine;

public class Board10 : MonoBehaviour
{
    public bool rojo10 = false;
    public bool azul10 = false;

    void Start()
    {
        rojo10 = false;
        azul10 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul10 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo10 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul10 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo10 = false;
        }
    }
}
