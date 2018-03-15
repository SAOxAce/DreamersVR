using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingApple : MonoBehaviour {

	public float fallSpeed = 1.0f;
    //ColorChange color = GetComponent<ColorChange>();

	void Update() {

        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        //ColorChange color = GetComponent<ColorChange>();
        /*if (color.ColorChanger())
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        }*/

    }
   /* public void Fall()
    {
        ColorChange color = GetComponent<ColorChange>();
        if (color.ColorChanger())
        {
            transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        }
       
    }*/
}
