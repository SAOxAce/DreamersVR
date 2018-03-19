using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSEEDLINGS : MonoBehaviour {

    //created from watercanFLOAT
    //makes fertilizer clickable

    public Collider fertFloorCollider;

    public void ActivateThis()
    {
        fertFloorCollider.enabled = true;

    }
}
