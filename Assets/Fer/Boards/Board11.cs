using UnityEngine;

public class Board11 : MonoBehaviour
{
    public bool rojo11 = false;
    public bool azul11 = false;

    void Start()
    {
        rojo11 = false;
        azul11 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul11 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo11 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul11 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo11 = false;
        }
    }
}
