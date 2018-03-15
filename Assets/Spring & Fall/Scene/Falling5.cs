using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling5 : MonoBehaviour {



	// Use this for initialization


	// Update is called once per frame
	void Update () {



		Invoke ("greg", 6 );
	}
	void greg() {
		transform.Translate (0, -.025f, 0);


	}
}