using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour {
    public bool isClickable = true;
    public void Unclick()
    {
        isClickable = false;
    }
}
