using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePlaneBehaviour : MonoBehaviour
{
    public float ms = 0.5f;
    public float speed = 2f;
    Vector3 movePattern;

    private void Start()
    {
        movePattern = new Vector3(-1, 0, 0); //This code works and I don't know why. Setting the x-value makes the plane fly in reverse, but negative x values will make it fly forward.

        //randomly determines if plane will start moving left or right
        float decide = Random.Range(0, 2);
        if (decide < 1)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate((movePattern * speed) * ms * Time.deltaTime);
    }

    void OnTriggerEnter(Collider coll)
    {
        //change direction when plane hits a wall
        if (coll.gameObject.tag == "Wall")
        {
            FaceForward();
        }

    }

    // ensures the plane faces the direction where it's going
    private void FaceForward()
    {
        if (gameObject.transform.rotation == Quaternion.Euler(0, 0, 0))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (gameObject.transform.rotation == Quaternion.Euler(0, 180, 0))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
