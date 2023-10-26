using UnityEngine;

public class DestroyA : MonoBehaviour
{
    CircleCollider2D circleCollider;

    CheckA checkA;
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        checkA = FindFirstObjectByType<CheckA>();
    }

    void Update()
    {
        if(checkA.cronometro <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
