using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private RaycastFromPlayer raycastFromPlayer;

    // Start is called before the first frame update
    void Start()
    {
        raycastFromPlayer = GameObject.FindWithTag("Player").GetComponent<RaycastFromPlayer>(); //pick that raycast script from the player
    }

    // Update is called once per frame
    void Update()
    {
        if (raycastFromPlayer.targetHit == transform) // If the raycast hits this object
        {

        }
    }
}
