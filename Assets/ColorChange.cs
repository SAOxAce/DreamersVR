using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    public Material ripe;
    public Material unripe;
    public float seconds;
	// Use this for initialization
	void Start () {
        Invoke("TimerChanger", 1f);
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ColorChanger()
    {
        GetComponent<Renderer>().material = ripe;
    }
    
    public void TimerChanger()
    {
        Invoke("ColorChanger", seconds);
    }

}
