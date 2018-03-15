using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text text;
    //public int counter;
	public int counterStr;

	void Start ()
	{
		counterStr = 0;
		ScoreChange ();
	}
    void ScoreChange()
    {
        //counterStr = counter.ToString();
		counterStr += 1;
        //text.text = "Score: " + counterStr;

    }
}
