using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSEEDScript : MonoBehaviour {

    public GameObject floatingShovel;
    public GameObject shovelStaticFloor;
    public GameObject HoleScript;

    public GameObject parentStem;
	
	// Update is called once per frame
	void WhenClickThis ()
    {
        Destroy(floatingShovel);
        shovelStaticFloor.SetActive(true);
        Destroy(HoleScript);

        parentStem.SetActive(true);

        //destroy this object aka ParentSeed Script + parentSeeds
        Destroy(gameObject);
        
        
	}
}
