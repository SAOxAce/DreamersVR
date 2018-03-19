using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCanFLOAT : MonoBehaviour {

    //after set active by waterCanfloor (script)
    //will exist until destroyed
    //meanwhile will remove stemsParent and replace with seedlingParent

    public GameObject watercanFLOAT;
    public GameObject parentStems;
    public GameObject parentSeedlings;
	
	// Update is called once per frame
	void Update () {

        Destroy(GameObject.Find("StemParent"));

        GameObject.Find("SeedsParent").SetActive(true);

        parentSeedlings.SetActive(true);

        //destroy floating watercan after 3 seconds
        Destroy(watercanFLOAT, 5);

    }
}
