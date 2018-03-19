using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScripting : MonoBehaviour {
    //////////HOLE MAKING////////
    /// <summary>
    /// makes objs until reaches max
    /// create: 
    /// -holes(active), seeds + stems + seedling + flowers (deactivated)
    /// reaches max:
    /// -activates SeedParent object (makes seeds visible)
    /// -SeedParent Object clickable w/script
    /// -deactivates colliderHoleScript
    /// 
    /// inactive prior:
    /// - seedParent
    /// 
    /// go to SeedParent1
    
    int count = 0;
    
    Vector3 rayPos;
    Vector3 totalPos;

    public GameObject holeObj;
    GameObject HoleClone;

    public GameObject seedChosenObj;
    GameObject cloneSeeds;
    public GameObject stemObj;
    GameObject cloneStems;
    public GameObject seedlingObj;
    GameObject cloneSeedling;
    public GameObject flowerChosenObj;
    GameObject cloneFlowers;

    public Collider holeScriptCollider;

    public GameObject parentSeedObj;
    public GameObject parentSeedScript;

    //position of the cursor/reticle (which is the center of the screen)
    Vector3 centerPos = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0.0f);

    //THIS FOR CREATING OBJECTS
    public void CreateOnClick()
    {
        RaycastHit hit;             // initializing the raycasthit 

        //ray position is where the center is, initizialising
        Ray ray = Camera.main.ScreenPointToRay(centerPos);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                ///tag name (ripe)////
                if (hit.collider.tag == "ripe")
                {
                    //assigning ray position, vector3
                    rayPos = hit.point;

                    //position of where to locate object is their choice in x, but fixed YZ position
                    totalPos = new Vector3(rayPos.x, 2, -183);
                }
            }
        }
     ///if objects created reaches max, turn off collider
     ///then turn next on
        if (count > 4)
        {
            
            //turn off this collider so can't click anymore and return
            holeScriptCollider.enabled = false;
            
            parentSeedObj.transform.GetChild(0).gameObject.SetActive(true);
            parentSeedObj.transform.GetChild(1).gameObject.SetActive(true);
            parentSeedObj.transform.GetChild(2).gameObject.SetActive(true);
            parentSeedObj.transform.GetChild(3).gameObject.SetActive(true);
            parentSeedObj.transform.GetChild(4).gameObject.SetActive(true);

            //activate SeedParent Script
            parentSeedScript.SetActive(true);

            return;

        }
        //create object
        HoleClone = Instantiate(holeObj, totalPos, Quaternion.identity);
        HoleClone.transform.parent = GameObject.Find("HoleParent").transform;

        //creating seeds, stems, seedlings, and flowers at that position but hiding them
        //until they are called
        cloneSeeds = Instantiate(seedChosenObj, totalPos, Quaternion.identity);
        cloneSeeds.transform.parent = GameObject.Find("SeedsParent").transform;
        cloneSeeds.SetActive(false);

        cloneStems = Instantiate(stemObj, totalPos, Quaternion.identity);
        cloneStems.transform.parent = GameObject.Find("StemParent").transform;
        cloneStems.SetActive(false);

        cloneSeedling = Instantiate(seedlingObj, totalPos, Quaternion.identity);
        cloneSeedling.transform.parent = GameObject.Find("SeedlingParent").transform;
        cloneSeedling.SetActive(false);

        cloneFlowers = Instantiate(flowerChosenObj, totalPos, Quaternion.identity);
        cloneFlowers.transform.parent = GameObject.Find("FlowerParent").transform;
        cloneFlowers.SetActive(false);

        //keeping count
        count++;

    }


}
