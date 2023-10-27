using UnityEngine;

public class BoardEnter : MonoBehaviour
{
    public bool Entro;
    public bool EntroR;

    CheckA checkA;
    CheckR checkR;

    void Start()
    {
        Entro = false;
        EntroR = false;

        checkA = FindFirstObjectByType<CheckA>();
        checkR = FindFirstObjectByType<CheckR>();
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

    void Update()
    {
        if (Entro)
        {
            while(checkA.cronometro > 0)
            {
                checkA.cronometro -= Time.deltaTime;

                if(checkA.cronometro < - 0.5)
                {
                    checkA.cronometro = 2;
                    Entro = false;
                }

                break;
            }
        }

        if (EntroR)
        {
            checkR.cronometro -= Time.deltaTime;

            if (checkR.cronometro < 0)
            {
                checkR.cronometro = 2;
            }
        }
    }
}
