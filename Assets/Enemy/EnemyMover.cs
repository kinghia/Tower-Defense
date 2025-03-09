using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Range(0f, 5f)] float speed;
    
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach (Waypoint waypoint in path)
        {
            Vector3 startPos = transform.position;
            Vector3 endPos = waypoint.transform.position;
            float tralverPercent = 0f;

            transform.LookAt(endPos);

            while (tralverPercent < 1f)
            {
                tralverPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPos, endPos, tralverPercent);
                yield return new WaitForEndOfFrame();
            } 
            
        }
    }

}
