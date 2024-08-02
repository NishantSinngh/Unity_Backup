using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScenes : MonoBehaviour
{
    float DelayInReload = 0.5f;
    public void PlayAgain()
    {
        Invoke("ReloadScene",DelayInReload);
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
