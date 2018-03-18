using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {
    /// <summary>
    /// USE THIS for mouseclicking to move an object to a specified position
    /// </summary>

    // This is the object you want to move
    public GameObject wall;
    //start
    private Vector3 startPos;
    //end
    private Vector3 endPosLeft;
    //distance
    private float distance = 10.0f;

    //Time to take from start to end in sec
    private float lerpTime = 5;
    //This will update the lerp time
    private float currentLerpTime = 0;

    private bool keyHit = false;

    //use this for initialization
    void Start()
    {
        startPos = wall.transform.position;
        endPosLeft = wall.transform.position + Vector3.left * distance;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            keyHit = true;
        }
        if (keyHit == true)
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
