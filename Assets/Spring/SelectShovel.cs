using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectShovel : MonoBehaviour {

    public GameObject shovelFloor;
    public Collider holeCollider;
   
    public GameObject floatShovel;

    public void ThisIsClicked () {

        //if this (shovel) object is clicked, 
        //will turn ON holeCollider + activate floating shovel and turn renderer/collider OFF
        

        //turn on the next step's collider to true
        //MOVE ON TO HOLE MAKING (Hole_Script)
        holeCollider.enabled = true;

        //activates floating shovel
        floatShovel.SetActive(true);

        //deactivate Shovel
        shovelFloor.SetActive(false);

        return;
    }
}
