using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text text;
    //public int counter;
    public string counterStr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ScoreChange()
    {
        //counterStr = counter.ToString();
        text.text = "Score: " + counterStr;
    }
}
