using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    float DelayInReload = 0.5f;
    public void PlayGame()
    {
        Invoke(methodName: "ReloadScene",time: DelayInReload);
    
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
}
