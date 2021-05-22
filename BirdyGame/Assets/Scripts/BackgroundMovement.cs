using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float ms = 0.5f;

    void FixedUpdate()
    {
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * ms * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * ms * Time.deltaTime);
        }*/
        transform.Translate(Vector3.down * ms * Time.deltaTime);
    }
}
