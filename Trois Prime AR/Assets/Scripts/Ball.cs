using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

 	public Rigidbody _ball;
 	 
	private int x;
	// Update is called once per frame
	void Start(){
		 
	}
	public void Throw () {
		_ball.GetComponent<Rigidbody>().isKinematic=false;
		 
		x=x+1;
		if(x>2)
		{x=0;}
		if(x==1)
		{
		_ball.GetComponent<Rigidbody>().AddForce(_ball.transform.forward * 10000);
		}
		if(x==2)
		{
		_ball.GetComponent<Rigidbody>().AddForce(_ball.transform.right * 10000);
		}
		 

	}

	 
}
