using UnityEngine;
using System.Collections;

public class CreateRaycast : MonoBehaviour
{
    /*
     * void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;             // initializing the raycasthit 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);        // initializing the ray
            if (Physics.Raycast(ray, out hit))
                if (hit.collider != null)
                {
                    ///tag name (erBridge)////
                    if (hit.collider.tag == "ripe")
                    {
                        Instantiate(objInstantiate, hit.point, Quaternion.identity);
                    }
                }


        }
    }
     */
     /// <summary>
     /// ///////////////
     /// </summary>


    public GameObject createObj;
    Vector3 rayPoint;
    Vector3 totalPos;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;             // initializing the raycasthit 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);        // initializing the ray

            if (Physics.Raycast(ray, out hit))
                if (hit.collider != null)
                {
                    ///tag name (erBridge)////
                    if (hit.collider.tag == "ripe")
                    {
                        rayPoint = hit.point;

                        totalPos = new Vector3(rayPoint.x, 10, -158);

                        //Instantiate(createObj, hit.point, Quaternion.identity);
                        Instantiate(createObj,totalPos, Quaternion.identity);
                    }
                }


        }
    }
}
  