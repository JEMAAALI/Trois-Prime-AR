using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {
     
	 private Animation anim;
 	 public GameObject _anim;
	 private int x;
	void Start () {
		
	}
	
	// Update is called once per frame
	public void PlayAnim () {
        x=x+1;
		if(x>2)
		{
			x=0;
		}
		anim = _anim.GetComponent<Animation>();
		
		if(x==0)
		{
		anim.Play("Eat");
		}
		if(x==1)
		{
		anim.Play("Wolfscream");
		_anim.GetComponent<AudioSource>().Play();
		}
		if(x==2)
		{
		anim.Play("Jog");
		}
 	}


}
