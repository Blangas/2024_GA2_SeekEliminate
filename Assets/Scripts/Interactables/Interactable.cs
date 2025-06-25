using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private RaycastFromPlayer raycastFromPlayer;
    private HighlightObject highlightObject;

    // Start is called before the first frame update
    void Start()
    {
        raycastFromPlayer = GameObject.FindWithTag("Player").GetComponent<RaycastFromPlayer>(); //pick that raycast script from the player
        highlightObject = transform.GetComponent<HighlightObject>(); // pick that highlight script from this same GameObject
    }

    // Update is called once per frame
    void Update()
    {
        if (raycastFromPlayer.targetHit == transform) // If the raycast hits this object
        {
            if (highlightObject)
            {
                highlightObject.Highlight(true);
            }
            else
            {

            }
        }
    }
}
