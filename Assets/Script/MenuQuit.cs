using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuQuit : MonoBehaviour
{
    public bool QuitWithEsc = false;
    public void ToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void Update()
    {
        if (QuitWithEsc)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ToMain();
            }
        }
        
    }
}
