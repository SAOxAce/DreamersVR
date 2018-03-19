using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentSTEM : MonoBehaviour {
    
    //makes WATERCAN clickable
    
    public Collider watercanCollider;
	
	public void ActivateThis () {
        watercanCollider.enabled = true;
        
	}
}
