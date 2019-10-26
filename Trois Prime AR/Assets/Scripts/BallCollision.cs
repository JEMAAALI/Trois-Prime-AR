using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Rigidbody[] _pins;
    void OnCollisionEnter(Collision hit)
	{
		if(hit.collider.tag=="Pin")
		{
            //foreach (Rigidbody pin in _pins)
		    //{
            //GetComponent<Rigidbody>().GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //pin.GetComponent<Rigidbody>().isKinematic=false;
            //pin.gameObject.AddComponent<Rigidbody>();
             hit.collider.gameObject.GetComponent<Rigidbody>().isKinematic=false;
			//Destroy(pin.GetComponent<Collider>().GetComponent<BoxCollider>());
            hit.collider.tag="";
           //}
		}
	}
}
