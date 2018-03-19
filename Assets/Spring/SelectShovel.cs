using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectShovel : MonoBehaviour {

    //static floor shovel
    public GameObject shovelFloor;
   
    //shovel over holes
    public GameObject floatShovel;

    //can create holes
    public GameObject holeScriptNum;

    public void ThisIsClicked () {

        //MOVE ON TO HOLE MAKING (Hole_Script1)
        holeScriptNum.SetActive(true);

        //activates floating shovel
        floatShovel.SetActive(true);

        //deactivate ShovelonFLoor
        shovelFloor.SetActive(false);

        return;
    }
}
