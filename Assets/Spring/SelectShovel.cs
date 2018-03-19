using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectShovel : MonoBehaviour {

    //came from seedChosen script aka the specific parent seed
    //when shovel is clicked ==> can HOLEmaking script is activated
    /// <summary>
    /// INATIVE prior: 
    /// - holeScript_1 (holeScript num)
    /// - floating shovel
    /// </summary>
    /// go to hole script1
    

    //static floor shovel
    public GameObject shovelFloorNum;
   
    //shovel over holes
    public GameObject floatShovel;

    //can create holes with this
    public GameObject holeScriptNum;

    public void ThisIsClicked () {

        //MOVE ON TO HOLE MAKING (Hole_Script1)
        holeScriptNum.SetActive(true);
        
        //deactivate ShovelonFLoor
        shovelFloorNum.SetActive(false);

        //activates floating shovel
        floatShovel.SetActive(true);

        //Destroy(shovelFloorNum);
        
        return;
    }
}
