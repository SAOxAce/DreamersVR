using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedChosen : MonoBehaviour {
    
    public GameObject PlantSeedsScript;

    public GameObject notChosen1;
    public GameObject notChosen2;
    public GameObject notChosen3;
    public GameObject notChosen4;

    // Update is called once per frame
    public void ActivateChosen ()
    {
        notChosen1.SetActive(false);
        notChosen2.SetActive(false);
        notChosen3.SetActive(false);
        notChosen4.SetActive(false);
        PlantSeedsScript.SetActive(true);
        
    }
   
   
}
