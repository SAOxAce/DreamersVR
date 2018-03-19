using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedChosen : MonoBehaviour {

    /// <summary>
    /// after all seeds menu is activated, and click on seed1
    // will destroy everything else but this seed
    // sets shovelalways on the floor to false but replaces with shovel1
    // moves on to shovelNum (shovel1)
    // Inactive prior: 
    //  -Shovel1
    /// </summary>

    public GameObject notChosen1;
    public GameObject notChosen2;
    public GameObject notChosen3;
    public GameObject notChosen4;
    public GameObject shovelNum;
    public GameObject shovelFloorAlways;
    

    // Update is called once per frame
    public void ActivateChosen ()
    {
        Destroy(notChosen1);
        Destroy(notChosen2);
        Destroy(notChosen3);
        Destroy(notChosen4);

        //turn off static do nothing shovel (hide)
        shovelFloorAlways.SetActive(false);

        //Shovel1 originally set false
        shovelNum.SetActive(true);
        
    }
      
}
