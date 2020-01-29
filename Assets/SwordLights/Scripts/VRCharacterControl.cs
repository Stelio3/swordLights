using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCharacterControl : MonoBehaviour {
    public float m_force;
    public Transform m_movementDirection;
    Rigidbody m_rigidBody;

	// Use this for initialization
	void Start () {
        m_rigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetMouseButton(0) )
        {
            //Debug.Log("moving");
            Vector3 floorProjected = m_movementDirection.transform.forward;
            floorProjected.y = 0;
            floorProjected.Normalize();
            m_rigidBody.AddForce(floorProjected * m_force);
        }

    }
}
