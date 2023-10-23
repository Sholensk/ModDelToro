using UnityEngine;

public class Board8 : MonoBehaviour
{
    public bool rojo8 = false;
    public bool azul8 = false;

    void Start()
    {
        rojo8 = false;
        azul8 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul8 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo8 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul8 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo8 = false;
        }
    }
}
