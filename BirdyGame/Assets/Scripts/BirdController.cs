using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float ms = 0.5f;
    private AudioSource chirps;
    public ParticleSystem feathers;

    void Start()
    {
        chirps = GetComponent<AudioSource>();
    }

    void Update()
    {
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * ms * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * ms * Time.deltaTime);
        }*/

        //transform.Translate(Vector3.up * ms * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            Debug.Log("ouch");
            chirps.Play();
            Instantiate(feathers, new Vector3 (transform.localPosition.x, transform.localPosition.y, transform.localPosition.z), Quaternion.identity);
        }
    }

}
