using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FertFloorScript : MonoBehaviour {

    public GameObject fertFLOAT;
    public GameObject fertFLOOR;
    public GameObject parentStems;
    public GameObject parentSeedlings;

    // Update is called once per frame
    void Update()
    {
        //sets fertFLOAT active
        fertFLOAT.SetActive(true);

        //deactivates fert floor
        fertFLOOR.SetActive(false);
        
    }
}
