using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindPlayerController : MonoBehaviour
{
    public GameObject windPrefab;
    private GameObject CreateWindInstance;

    private Vector3 mousePosDown = new Vector3();
    private Vector3 mousePosUp = new Vector3();
    public float mouseVectLength;

    private float windDirX;
    private float windDirY;

    ForceMode WindFoce;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var screenPoint = Input.mousePosition;
            screenPoint.z = 10.0f; //distance of the plane from the camera
            mousePosDown = Camera.main.ScreenToWorldPoint(screenPoint);
            //Debug.Log("this is the mousePosDown x: " + mousePosDown.x);
            //Debug.Log("this is the mousePosDown y: " + mousePosDown.y);
        }

        if (Input.GetButtonUp("Fire1"))
        {
            var screenPoint1 = Input.mousePosition;
            screenPoint1.z = 10.0f; //distance of the plane from the camera
            mousePosUp = Camera.main.ScreenToWorldPoint(screenPoint1);
            //Debug.Log("this is the mousePosUp x: " + mousePosUp.x);
            //Debug.Log("this is the mousePosUp y: " + mousePosUp.y);

            //angle of the vector between the two points
            float angle = (Mathf.Atan2(mousePosUp.y - mousePosDown.y, mousePosUp.x - mousePosDown.x) * (180 / Mathf.PI));

            //length between the points
            mouseVectLength = (Mathf.Sqrt(Mathf.Pow(mousePosUp.x - mousePosDown.x, 2) + (Mathf.Pow(mousePosUp.y - mousePosDown.y, 2))));

            //Debug.Log("this is the angle: " + angle);
            //Debug.Log("this is the length: " + mouseVectLength);

            //creates quaterion angle on z axis
            Quaternion windPrefabAngle = new Quaternion();
            windPrefabAngle = Quaternion.AngleAxis(angle, Vector3.forward);

            //creates an instance of the windPrefab
            CreateWindInstance = Instantiate(windPrefab, mousePosDown, windPrefabAngle);
            //resizes the scale of the wind
            CreateWindInstance.transform.localScale = new Vector3(mouseVectLength / 5f, mouseVectLength / 3f, mouseVectLength / 5f);

            //sets the created wind instance's strength based on how large the wind instance is
            CreateWindInstance.GetComponent<WindArea>().Strength = mouseVectLength * 1.1f;

            //sets the wind direction by changing values in the WindArea script

            windDirX = CreateWindInstance.transform.localScale.x;
            windDirY = CreateWindInstance.transform.localScale.y;
            if (mousePosDown.x > mousePosUp.x)
            {
                windDirX *= -1;
            }

            if (mousePosDown.y > mousePosUp.y)
            {
                windDirY *= -1;
            }

            //NO Z-AXIS DIRECTION SO OBJECTS DON'T FLY OFF-SCREEN
            CreateWindInstance.GetComponent<WindArea>().Direction = new Vector3(windDirX, windDirY, 0);

            //destry instance in a second
            Object.Destroy(CreateWindInstance, 1.0f);
        }
    }
}
