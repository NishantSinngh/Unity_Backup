using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float DelayInReload = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool crashed = true;
    void OnTriggerEnter2D(Collider2D other)
     {
        if (other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControl();
            if(crashed)
            {
                crashEffect.Play();
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
                crashed = false;
            }
            Invoke(methodName: "ReloadScene",time: DelayInReload);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(2);
    }
}
