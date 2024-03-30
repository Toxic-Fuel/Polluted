using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Sci-fi");
    }
    public void Options()
    {
        Debug.Log("If you see this, then it works.");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
