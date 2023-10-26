using UnityEngine;

public class BoardEnter : MonoBehaviour
{

    bool Entro = false;
    bool EntroR = false;
    
    CheckA checkA;
    CheckR checkR;

    void Start()
    {
        checkA = FindFirstObjectByType<CheckA>();
        checkR = FindFirstObjectByType<CheckR>();
    }

    private void Update()
    {
        if(Entro == true)
        {
            checkA.cronometro -= Time.deltaTime;
        }

        if(EntroR == true)
        {
            checkR.cronometro -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            Entro = true;
        }

        if (collision.CompareTag("Rojo"))
        {
            EntroR = true;
        }
    }
}
