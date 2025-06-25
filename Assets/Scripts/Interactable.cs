using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public RaycastFromPlayer raycastFromPlayer;

    // Start is called before the first frame update
    void Start()
    {
        raycastFromPlayer = GameObject.FindWithTag("Player").GetComponent<RaycastFromPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
