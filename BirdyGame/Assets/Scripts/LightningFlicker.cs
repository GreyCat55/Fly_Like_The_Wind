using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class LightningFlicker : MonoBehaviour
{
    private bool isFlickering = false;
    public float timeDelay;
    public float flickerSpeed;

    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }
    }

    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = UnityEngine.Random.Range(0.01f, flickerSpeed);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = UnityEngine.Random.Range(0.01f, flickerSpeed);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}
