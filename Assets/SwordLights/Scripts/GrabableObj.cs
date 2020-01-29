using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabableObj : MonoBehaviour
{
    bool m_bgrab;
    
    public void Grab(GameObject hand)
    {
        m_bgrab = true;
        transform.SetParent(hand.transform, true);
        transform.localPosition = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        if (m_bgrab)
        {
            transform.localPosition = Vector3.zero;
            if(OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger)|| Input.GetMouseButtonUp(0))
            {
                transform.SetParent(null, true);
                m_bgrab = false;
            }
        }  
    }
}
