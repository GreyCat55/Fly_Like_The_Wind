using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEntered : MonoBehaviour
{
     public void OnTriggerEnter (Collider col){
         Debug.Log("lost life!");
        HealthBar.health -= 1;
    }
}
