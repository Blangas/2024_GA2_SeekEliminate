using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTopDownController : MonoBehaviour
{
    public int moveSpeed = 10;

    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //movement in 2 axis
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveH * moveSpeed * Time.deltaTime, 0, moveV * moveSpeed * Time.deltaTime);
        transform.position += movement;

        //Next 7 lines of code from https://discussions.unity.com/t/making-the-player-face-the-direction-of-the-cursor/801532/3
        // Converting the mouse position to a point in 3D-space
        Vector3 point = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        // Using some math to calculate the point of intersection between the line going through the camera and the mouse position with the XZ-Plane
        float t = cam.transform.position.y / (cam.transform.position.y - point.y);
        Vector3 finalPoint = new Vector3(t * (point.x - cam.transform.position.x) + cam.transform.position.x, 1, t * (point.z - cam.transform.position.z) + cam.transform.position.z);
        //Rotating the object to that point
        transform.LookAt(finalPoint, Vector3.up);
    }
}
