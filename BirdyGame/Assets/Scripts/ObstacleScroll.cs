using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScroll : MonoBehaviour
{
    public float ms = 0.5f;
    public float timeUntilDeletion = 10.0f;
    private float timeRemaining;
    private bool isQueuedForDeletion;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-1.1f, 1.1f), GameObject.Find("SM_Bird").transform.position.y + 4.0f, 0.0f);
        isQueuedForDeletion = false;
        timeRemaining = timeUntilDeletion;
        //transform.localScale = new Vector3(Random.Range(0.5f, 0.75f), Random.Range(0.5f, 0.75f), 1f);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * ms * Time.deltaTime);

        if (isQueuedForDeletion)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                //Debug.Log(timeRemaining);
            }
            else
            {
                //Debug.Log("Out of time");
                timeRemaining = 0;
                Destroy(gameObject);
            }
        }
    }

    //NOTE: Obstacle objects need a mesh renderer for the below two functions to trigger
    private void OnBecameInvisible()
    {
        isQueuedForDeletion = true;
        //Debug.Log(isQueuedForDeletion);
    }

    private void OnBecameVisible()
    {
        isQueuedForDeletion = false;
        timeRemaining = timeUntilDeletion;
        //Debug.Log(isQueuedForDeletion);
    }
}