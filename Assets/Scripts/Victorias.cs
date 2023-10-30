using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victorias : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("MenuInicio");
    }

    public void Jugar()
    {
        SceneManager.LoadScene("Fer");
    }
}
