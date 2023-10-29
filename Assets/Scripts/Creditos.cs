using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creditos : MonoBehaviour
{

    private void Start()
    {
        Invoke("CambiarEscena", 27);
    }
    public void CambiarEscena()
    {
        SceneManager.LoadScene("MenuInicio");
    }
}
