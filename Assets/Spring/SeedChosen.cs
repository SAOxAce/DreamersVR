using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedChosen : MonoBehaviour {
    //after all seeds menu is activated, and click on seed1
    //will deactivate everything else but this seed
    public GameObject notChosen1;
    public GameObject notChosen2;
    public GameObject notChosen3;
    public GameObject notChosen4;
    public GameObject shovelNum;
    public GameObject shovelFloorAlways;

    public GameObject PlantSeedsScript;

    // Update is called once per frame
    public void ActivateChosen ()
    {
        Destroy(notChosen1);
        Destroy(notChosen2);
        Destroy(notChosen3);
        Destroy(notChosen4);

        //Shovel1 originally set false
        shovelNum.SetActive(true);

        //turn off static do nothing shovel (hide)
        shovelFloorAlways.SetActive(false);

        
    }
   
   
}
