using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuracionesaotrasescenas : MonoBehaviour
{
    public void Awake()
    {
        var noDestruir = FindObjectsOfType<Configuracionesaotrasescenas>();
        if (noDestruir.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
