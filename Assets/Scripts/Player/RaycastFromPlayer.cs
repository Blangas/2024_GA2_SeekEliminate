using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFromPlayer : MonoBehaviour
{
    public float rayDistance = 100;
    public float rayStart = 0.5f;
    public GameObject targetHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition; //gets the mouse position

        if (Physics.Raycast(transform.position + transform.forward * rayStart, transform.forward, out RaycastHit hitInfo, rayDistance))
        { 
            Debug.Log("Player targeting at " + hitInfo.ToString());
            targetHit = hitInfo.collider.gameObject;
        }
        else if (targetHit)
        {
            targetHit = null;
        }
    }
}
