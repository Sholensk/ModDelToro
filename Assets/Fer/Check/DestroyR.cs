using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyR : MonoBehaviour
{
    CircleCollider2D circleCollider;

    CheckR checkR;
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        checkR = FindFirstObjectByType<CheckR>();
    }

    void Update()
    {
        if (checkR.cronometro <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
