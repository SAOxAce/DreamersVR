using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSEEDScript : MonoBehaviour {

    // for: SeedParent
    //removes floating shovel + hole script + holes + seeds + seedScript
    //activates stems (makes visible)
    /// <summary>
    /// inactive prior:
    /// - static shovel on floor (noscripts)
    /// - parentstems (no scripts)
    /// - watercan FLOOR collider (script)
    /// </summary>
    /// go to watercanFLOOR (+script)

    public GameObject floatingShovel;
    public GameObject shovelStaticFloor;
    public GameObject HoleScript;
    public Collider watercanCollider;

	
	// Update is called once per frame
	public void WhenClickThis ()
    {
        Destroy(floatingShovel);

        shovelStaticFloor.SetActive(true);

        //FIXME
        Destroy(HoleScript);

        GameObject.Find("StemParent").transform.GetChild(0).gameObject.SetActive(true);
        GameObject.Find("StemParent").transform.GetChild(1).gameObject.SetActive(true);
        GameObject.Find("StemParent").transform.GetChild(2).gameObject.SetActive(true);
        GameObject.Find("StemParent").transform.GetChild(3).gameObject.SetActive(true);
        GameObject.Find("StemParent").transform.GetChild(4).gameObject.SetActive(true);
        
        watercanCollider.enabled = true;

        Destroy(GameObject.Find("SeedsParent"));

        //destroy this object aka ParentSeed Script + parentSeeds
        Destroy(gameObject);
        
	}
}
