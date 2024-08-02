using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private List<WayPoint> wayPoints = new List<WayPoint>();

    private void Start()
    {
        StartCoroutine(FollowPath());
    }
    // to make the player move from a fixed path which is organised in wayPoints list
    IEnumerator FollowPath()
    {
        foreach(WayPoint wayPoint in wayPoints)
        {
            Vector3 startPosition = transform.position;
            Vector3 endPosition = wayPoint.transform.position;
            float travelPercent = 0f;
            while(travelPercent < 1f)
            {
                travelPercent += Time.deltaTime;
                transform.position = Vector3.Lerp(startPosition, endPosition,travelPercent);
                yield return new WaitForEndOfFrame();
            }
        }
            
    }
}
