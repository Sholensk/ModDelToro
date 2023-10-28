using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void sceneManager(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }

}

