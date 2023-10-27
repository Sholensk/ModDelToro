using UnityEngine;

public class CheckA : MonoBehaviour
{
    public float cronometro;

    CircleCollider2D circleCollider;

    BoardEnter boardEnter;

    void Start()
    {
        cronometro = 2;
        boardEnter = FindAnyObjectByType<BoardEnter>();
        circleCollider = gameObject.GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        StartCheckA();

        if(cronometro <= 0)
        {
            boardEnter.Entro = false;
        }
    }

    void StartCheckA()
    {
        if(cronometro <= .2)
        {
            circleCollider.enabled = true;
        }
    }
}
