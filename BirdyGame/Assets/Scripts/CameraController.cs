using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform birdPrefab;

    public Transform bg1;
    public Transform bg2;


    private float size;
   

    

    private Vector3 cameraTargetPos = new Vector3();
    private Vector3 bg1TargetPos = new Vector3();
    private Vector3 bg2TargetPos = new Vector3();
    
    

    void Start()
    {
        //multiply by # for the scale of background (scale * 5.12 * 2?????
        size = bg1.GetComponent<BoxCollider2D>().size.y;
       

        
    }

    void FixedUpdate()
    {
        //camera follow
        //+1 moves it down a bit
        Vector3 targetPos = SetPos(cameraTargetPos, 0, birdPrefab.position.y + 1, -10);

        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);

        //background
        if (transform.position.y >= bg2.position.y)
        {
            bg1.position = SetPos(bg1TargetPos, bg1.position.x, (bg2.position.y + size), 0);
            SwitchBg();
        }

        //if player goes lower then first background or going down
        if (transform.position.y < bg1.position.y )
        {
            bg2.position = SetPos(bg2TargetPos, bg2.position.x, bg1.position.y - size, 0);
            SwitchBg();
        }
    }

    private void SwitchBg()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    
       
    }

    private Vector3 SetPos(Vector3 pos, float x, float y, float z)
    {
        pos.x = x;
        pos.y = y;
        pos.z = z;
        return pos;
    }
}
