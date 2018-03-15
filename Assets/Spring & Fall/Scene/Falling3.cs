using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling3 : MonoBehaviour {



	// Use this for initialization


	// Update is called once per frame
	void Update () {



		Invoke ("greg", 4);
	}
	void greg() {
		transform.Translate (0, -.025f, 0);


	}
}