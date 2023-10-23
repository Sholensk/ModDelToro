using UnityEngine;

public class Board7 : MonoBehaviour
{
    public bool rojo7 = false;
    public bool azul7 = false;

    void Start()
    {
        rojo7 = false;
        azul7 = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul7 = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo7 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            azul7 = false;
        }

        if (collision.CompareTag("Rojo"))
        {
            rojo7 = false;
        }
    }
}
