using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour {

	public void selectScene(){
		switch (this.gameObject.name) {
		case "GardenSceneButton":
			SceneManager.LoadScene ("garden_tutorial");
			break;
		case "FallSceneButton": 
			SceneManager.LoadScene ("applescene"); 
			break;
		}
	}


	// Use this for initialization


	// Update is called once per frame
	void Update () {



	}

}
