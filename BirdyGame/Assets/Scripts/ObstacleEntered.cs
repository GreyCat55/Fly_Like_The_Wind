using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEntered : MonoBehaviour
{
     public void OnTriggerEnter (Collider col){
        if (col.gameObject.tag == "Obstacle")
        {
            Debug.Log("lost life!");
            HealthBar.health -= 1;
        }
    }
}
