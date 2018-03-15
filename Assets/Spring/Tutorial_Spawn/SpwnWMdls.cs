using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwnWMdls : MonoBehaviour {

    public GameObject allSeeds;
    public GameObject shovelFloor;
    public GameObject shvlOvrHole;
    public GameObject hole;
    public GameObject seedsOvrHole;
    public GameObject stems;
    public GameObject waterFloor;
    public GameObject waterOvrHole;
    public GameObject seedlngs;
    public GameObject fertFloor;
    public GameObject fertOverHole;
    public GameObject flowerEnd;

    public Transform allSeedsPos;
    public Transform shovelFloorPos;
    public Transform shvlOvrHolePos;
    public Transform holePos;
    public Transform seedsOvrHolePos;
    public Transform stemsPos;
    public Transform waterFloorPos;
    public Transform waterOvrHolePos;
    public Transform seedlngPos;
    public Transform fertFloorPos;
    public Transform fertOverHolePos;
    public Transform flowerEndPos;

    public Transform hideThese;      // new Vector3(89, 30, -170)
   

    //Vector3 targetPosition;
    int countClicks = 0;
        
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            countClicks++;
        }

        if (countClicks == 1)
        {
            //all seeds appears
            allSeeds.transform.position = allSeedsPos.position;
        }
        
        else if (countClicks == 2)
        {
            //all seeds disappear
            Destroy(allSeeds);
        }
        else if (countClicks == 3)
        {
            //shovel on FLOOR moves out of camera view
            shovelFloor.transform.position = hideThese.position;
            //shovel over HOLE appears
            shvlOvrHole.transform.position = shvlOvrHolePos.position;
        }
        else if (countClicks == 4)
        {
            //hole appears
            hole.transform.position = holePos.position;
            
        }
        else if (countClicks == 5)
        {
            //shovel disappears
            Destroy(shvlOvrHole);
            //shovel on FLOOR back to position
            shovelFloor.transform.position = shovelFloorPos.position;
            //individual seeds over hole appear
            seedsOvrHole.transform.position = seedsOvrHolePos.position;
        }
        else if (countClicks == 6)
        {
            //individual seeds over hole disappear disappears
            Destroy(seedsOvrHole);
            //hole disappears
            Destroy(hole);
            //stems appear
            stems.transform.position = stemsPos.position;
            
        }
        else if (countClicks == 7)
        {
            //water can on FLOOR moves out of camera view
            waterFloor.transform.position = hideThese.position;
            //water can over stems appears
            waterOvrHole.transform.position = waterOvrHolePos.position;
       

        }
        else if (countClicks == 8)
        {
            //stem disappear
            Destroy(stems);
            //water can over HOLE disappears
            Destroy(waterOvrHole);
            //Water can back to original position
            waterFloor.transform.position = waterFloorPos.position;

            //seedlings appear       
            seedlngs.transform.position = seedlngPos.position;

        }
        else if (countClicks == 9)
        {
            //fertilzer on FLOOR moves out of camera
            fertFloor.transform.position = hideThese.position;
            //fertilzer over HOLE appears
            fertOverHole.transform.position = fertOverHolePos.position;
        }
        else if (countClicks == 10)
        {
            //fertilizer over HOLE disappears
            Destroy(fertOverHole);
            //Fertilizer on FLOOR moves back
            fertFloor.transform.position = fertFloorPos.position;

        }
        else if (countClicks == 11)
        {
            //seedlings diappears
            Destroy(seedlngs);
            //end flowers appear
            flowerEnd.transform.position = flowerEndPos.position;

        }

        //public Vector3 pos1;
        //obj1.transform.position = new Vector3(0, 0, 0);
    }
}
