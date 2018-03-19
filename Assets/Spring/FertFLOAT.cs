using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FertFLOAT : MonoBehaviour {

    public GameObject parentSeedling;
    public GameObject parentFlower;

	
	// Update is called once per frame
	void WhenClickThis () {
        Destroy(parentSeedling);

        parentFlower.SetActive(true);

        Destroy(gameObject, 3);
        return;
	}
}
