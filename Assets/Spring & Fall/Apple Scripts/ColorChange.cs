using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    public Material ripe;
    public Material unripe;
    public float seconds;
    public bool isRipe = false;
	// Use this for initialization
	void Start () {
        Invoke("TimerChanger", 1f);
    }
		
    public void ColorChanger()
    {
        GetComponent<Renderer>().material = ripe;
        isRipe = true;
    }
    
    public void TimerChanger()
    {
        Invoke("ColorChanger", seconds);
    }

}
