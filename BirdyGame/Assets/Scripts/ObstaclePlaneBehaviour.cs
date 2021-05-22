using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePlaneBehaviour : MonoBehaviour
{
    public float ms = 0.5f;
    public float speed = 2f;
    Vector3 movePattern;
    //Rigidbody rb;

    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
        movePattern = new Vector3(1, 0, 0);

        //randomly determines if plane will start moving left or right
        float decide = Random.Range(0, 2);
        if (decide < 1) 
        {
            movePattern.x *= -1;
        }
        Debug.Log(decide);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate((movePattern * speed) * ms * Time.deltaTime);
    }

    void OnTriggerEnter(Collider coll)
    {
        Debug.Log("WALL");
        //change direction when plane hits a wall
        if (coll.gameObject.tag == "Wall")
        {
            movePattern.x *= -1;
        }
    }

}
