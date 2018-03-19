using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour {

    int count = 0;
    public GameObject createObj;
    Vector3 rayPos;
    Vector3 totalPos;

    public Collider holeCollider;

    //position of the cursor/reticle (which is the center of the screen)
    Vector3 centerPos = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0.0f);

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
        //if objects created reaches max, turn function "OFF"/ stop creating more
        if (count > 4)
        {   
            holeCollider.enabled = false;
            return;
        }
        //create object
        Instantiate(createObj, totalPos, Quaternion.identity);
        //keeping count
        count++;

    }
    
}
