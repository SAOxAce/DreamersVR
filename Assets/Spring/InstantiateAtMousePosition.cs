using UnityEngine;
using System.Collections;

public class InstantiateAtMousePosition : MonoBehaviour {

    /// <summary>
    /// USEFUL FOR NOT DEALING WITH DAYDREAM, WILL USE RAYCAST INSTEAD
    /// </summary>

	Vector3 mousePosition,targetPosition;

	//To Instantiate TargetObject at mouse position
	public Transform targetObject;

    //float distance=110f;
    float distance = 60f;

    // Use this for initialization
    public void Start () {
	
	}

    // Update is called once per frame
    public void locatePosition()
    {

        //To get the current mouse position
        mousePosition = Input.mousePosition;

        //Convert the mousePosition according to World position
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, distance));
        

        //Set the position of targetObject
        //targetObject.position=targetPosition;
        targetObject.position = new Vector3(targetPosition.x, -10, -20);
       
        /*//If Left Button is clicked
        if (Input.GetMouseButtonUp(0))
		{
			//create the instance of targetObject and place it at given position.
			Instantiate(targetObject,targetObject.transform.position,targetObject.transform.rotation);	
		}
        */
        
    }     
        
    public void PlaceObject()
    {    
        Instantiate(targetObject, targetObject.transform.position, targetObject.transform.rotation);

    }
}
