using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindArea : MonoBehaviour
{
    public float Strength;
    public Vector3 Direction;
    //public bool isLeftClickHeld = false;

    private void Update()
    {
        GameObject theWindPlayer = GameObject.Find("Wind Player");

        WindPlayerController newStrength = theWindPlayer.GetComponent<WindPlayerController>();
        Strength = newStrength.mouseVectLength * 1.1f;
    }
}
