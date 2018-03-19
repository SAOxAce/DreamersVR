using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_AllSeeds : MonoBehaviour {

    // activates menu seeds
    //destroys allseeds on floor

    public GameObject allSeeds;
	
	// Update is called once per frame
	public void setAllSeeds () {
        allSeeds.SetActive(true);
        Destroy(gameObject);
	}
}
