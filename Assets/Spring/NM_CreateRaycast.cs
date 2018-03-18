using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NM_CreateRaycast : MonoBehaviour {

    public GameObject createObj;
    Vector3 rayPoint;
    Vector3 totalPos;
    Vector3 center = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0.0f);

    public void CreateOnClick()
    {
        RaycastHit hit;             // initializing the raycasthit 
        
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);        // initializing the ray
        Ray ray = Camera.main.ScreenPointToRay(center);        // initializing the ray
        

        if (Physics.Raycast(ray, out hit))
            if (hit.collider != null)
            {
                ///tag name (erBridge)////
                if (hit.collider.tag == "ripe")
                {
                    rayPoint = hit.point;

                    totalPos = new Vector3(rayPoint.x, 10, -158);

                    //Instantiate(createObj, hit.point, Quaternion.identity);
                    Instantiate(createObj, totalPos, Quaternion.identity);
                }
            }
    }
}
