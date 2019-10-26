using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour {

    public Texture2D[] _textures;
	public Material _skate;
	private int x=1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Change () {
		x=x+1;
		if(x>3)
		{
			x=1;
		}
		_skate.mainTexture=_textures[x-1];
        //Instantiate(_effect,_effectPos.transform.position,_effectPos.transform.rotation);
	}

	 
}
