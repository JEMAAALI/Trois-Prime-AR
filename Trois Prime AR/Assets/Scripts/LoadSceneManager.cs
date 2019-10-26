using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Scene1 () {

		SceneManager.LoadScene("AR-1"); 
	}

	public void Scene2 () {

		SceneManager.LoadScene("AR-2"); 
	}

	public void Scene3 () {

		SceneManager.LoadScene("AR-3"); 
	}

	public void Refresh()
	{
		Scene scene = SceneManager.GetActiveScene();
	    SceneManager.LoadScene(scene.name);	
	}
}
