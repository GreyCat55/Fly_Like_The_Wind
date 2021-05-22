using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScroll : MonoBehaviour
{
    public float ms = 0.5f;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-1.1f, 1.1f), GameObject.Find("SM_Bird").transform.position.y + 4.0f, 0.0f);
        //transform.localScale = new Vector3(Random.Range(0.5f, 0.75f), Random.Range(0.5f, 0.75f), 1f);
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.down * ms * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject, 5.0f);
    }
}