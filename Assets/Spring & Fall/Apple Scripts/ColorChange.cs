using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    public Material ripe;
    public Material unripe;
    public float seconds;
    public bool isRipe = false;
    public float fallSpeed = 1f;
	// Use this for initialization
	void Start () {
        Invoke("TimerChanger", 1f);
    }
    void Update()
    {
        Invoke("Fall", seconds + 1);
    }

    public void ColorChanger()
    {
        GetComponent<Renderer>().material = ripe;
        isRipe = true;
        
        //return isRipe;
    }
    public void Fall()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
    }
    
    public void TimerChanger()
    {
        Invoke("ColorChanger", seconds);
    }

}
