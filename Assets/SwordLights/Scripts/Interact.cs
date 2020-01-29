using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        bool bClicked = false;
        RaycastHit hit;

        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) || Input.GetMouseButtonDown(0))
        {
            bClicked = true;
        }
        if(Physics.Raycast(new Ray(transform.position, transform.forward),out hit, Mathf.Infinity))
        {
            GameObject target = hit.collider.gameObject;
            Interactable interactable = target.GetComponent<Interactable>();
            if(interactable != null)
            {
                interactable.Down();
                if (bClicked)
                {
                    interactable.Clicked();
                }
            }
        }
    }
}
