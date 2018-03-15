using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayui : MonoBehaviour {
	public string myString;
	public Texture myText;
	public float fadeTime;
	public bool displayInfo;
	// Use this for initialization
	void Start () {
	//	myText = GameObject.Find ("Text").GetComponent<Text> ();
	//	myText.color = Color.clear;

	}
	
	// Update is called once per frame
	void Update () {
		FadeText ();
	}
	void OnMouseOver(){
		displayInfo = true;}
	void OnMouseExit(){
		displayInfo = false;}
	void FadeText(){
		{if (displayInfo) {
				//myText.text = myString;
			//	myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
			} else {
		//	myText.color = Color.Lerp (myText.color, Color.clear, fadeTime*Time.deltaTime);
		}
	}}}
