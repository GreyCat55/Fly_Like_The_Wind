using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    // Start is called before the first frame update

    private LineRenderer lineRenderer;
    Vector3 mousePosDown, currentMousePos;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
                lineRenderer.positionCount = 2;
                lineRenderer.startWidth = 0.01f;
                lineRenderer.endWidth = 0.01f;
                var screenPoint = Input.mousePosition;
                screenPoint.z = 9.0f; //distance of the plane from the camera
                mousePosDown = Camera.main.ScreenToWorldPoint(screenPoint);
                lineRenderer.SetPosition(0, mousePosDown);
                Debug.Log("Set point of origin at " + mousePosDown);
        }
        if (Input.GetMouseButton(0)) {
            var screenPoint1 = Input.mousePosition;
            screenPoint1.z = 9.0f; //distance of the plane from the camera
            currentMousePos = Camera.main.ScreenToWorldPoint(screenPoint1);
            lineRenderer.SetPosition(1, currentMousePos);
            Debug.Log("Going to " + currentMousePos);
        }
        if (Input.GetMouseButtonUp(0))
        {
            lineRenderer.positionCount = 0;
        }
    }
}
