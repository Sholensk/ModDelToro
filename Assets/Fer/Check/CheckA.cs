using UnityEngine;

public class CheckA : MonoBehaviour
{
    public float cronometro;

    CircleCollider2D circleCollider;

    void Start()
    {
        circleCollider = gameObject.GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        StartCheckA();
    }

    void StartCheckA()
    {
        if(cronometro <= .2)
        {
            circleCollider.enabled = true;
        }
    }
}
