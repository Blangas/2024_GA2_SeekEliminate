using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTopDownController : MonoBehaviour
{
    public int moveSpeed = 10;

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
    }
}
