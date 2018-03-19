using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSeeds : MonoBehaviour {

    int count = 0;
    public Collider plantSeedsCollider;
    public GameObject chosenSeed;
    GameObject SeedClone;
    public GameObject AutomaticStuff;

    Vector3 rayPos;
    Vector3 totalPos;
    
    Vector3 centerPos = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0.0f);
    
    //THIS FOR CREATING SEEDS
    public void CreateOnClick()
    {
        RaycastHit hit;  
        Ray ray = Camera.main.ScreenPointToRay(centerPos);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null)
            {
                ///tag name (ripe)////
                if (hit.collider.tag == "ripe")
                {
                    rayPos = hit.point;
                    totalPos = new Vector3(rayPos.x,3, -185);
                }
            }
        }
        ///place seeds over hole
        /// then turns deactivates all the seedChosen
        if (count > 4)
        {
            //destroy seeds
            //Destroy(GameObject.Find("SeedParent"));

            //activate automatic stuff (just clicking through water, fertilizer)
            AutomaticStuff.SetActive(true);


            return;

        }
        //replicates seed chosen, adds to parent SeedParent
        /////NEED TO A FLAT VERSION
        SeedClone = Instantiate(chosenSeed, totalPos, Quaternion.identity);
        SeedClone.transform.parent = GameObject.Find("SeedParent").transform;

        count++;

    }
}
