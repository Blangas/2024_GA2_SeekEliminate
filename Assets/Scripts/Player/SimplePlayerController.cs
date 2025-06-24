using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script from John Klima class

public class SimplePlayerController : MonoBehaviour
{
    public int moveSpeed = 10;
    public int turnSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxis("Horizontal");
        float move = Input.GetAxis("Vertical");

        //rotation
        transform.Rotate(transform.up * turn * turnSpeed * Time.deltaTime);

        //movement
        transform.position += transform.forward * move *moveSpeed * Time.deltaTime;
    }
}
