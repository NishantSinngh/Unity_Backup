using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] int pointsToAdd = 100;

    bool wasCollected = false; // to prevent double collection of a coin
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" && !wasCollected)
        {
            Debug.Log("picked");
            wasCollected = true;
            FindObjectOfType<GameSession>().AddToScore(pointsToAdd);
            // AudioSource.PlayClipAtPoint(audioClip, Camera.main.transform.position); // not working in webGL build
            Destroy(gameObject); // destroys the gameObject on which the script is living
        }
    }
}

