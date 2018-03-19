using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCanFLOOR : MonoBehaviour {

    //after turned on by parentSTEM
    //for: watercan floor
    //can click now
    /// <summary>
    /// deactivated prior:
    /// - watercanFLOAT
    /// </summary>
    /// go to watercan float

    public GameObject watercanFLOOR;
    public GameObject watercanFLOAT;

	public void ActivateThis () {

        watercanFLOAT.SetActive(true);
        watercanFLOOR.SetActive(false);

	}
}
