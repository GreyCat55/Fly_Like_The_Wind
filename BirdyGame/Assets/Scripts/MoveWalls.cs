using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWalls : MonoBehaviour
{
    private Vector3 birdTargetPos = new Vector3();

    public Transform birdPrefab;

    void FixedUpdate()
    {
        Vector3 targetPos = SetPos(birdTargetPos, 0, birdPrefab.position.y, 0);
        //Vector3 newPosLeftWall = SetPos(oGLeftwallTargetPos, 0, birdPrefab.position.y, -10);

        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);
        //leftWall.transform.position = Vector3.Lerp(transform.position, newPosLeftWall, 0.2f);
    }

    private Vector3 SetPos(Vector3 pos, float x, float y, float z)
    {
        pos.x = x;
        pos.y = y;
        pos.z = z;
        return pos;
    }
}
