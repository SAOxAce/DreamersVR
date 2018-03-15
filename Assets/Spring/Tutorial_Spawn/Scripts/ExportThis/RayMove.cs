using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayMove : MonoBehaviour {
    public GameObject wall;
    //start
    private Vector3 startPos;
    //end
    private Vector3 endPosLeft;
    //distance
    private float distance = 300.0f;
    //Time to take from start to end in sec
    private float lerpTime = 5;
    //This will update the lerp time
    private float currentLerpTime = 0;
    private bool keyHit = false;

    void Start()
    {
        startPos = wall.transform.position;
        endPosLeft = wall.transform.position + Vector3.left * distance;
    }
    void Update()
    {      
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                if (hit.collider != null)
                {
                    ///tag name (erBridge)////
                    if (hit.collider.tag == "erSphere")
                    {
                        currentLerpTime += Time.deltaTime;
                        if (currentLerpTime >= lerpTime)
                        {
                            currentLerpTime = lerpTime;
                        }
                        float Perc = currentLerpTime / lerpTime;
                        wall.transform.position = Vector3.Lerp(startPos, endPosLeft, Perc);
                    }
                }
        }
    }
}
