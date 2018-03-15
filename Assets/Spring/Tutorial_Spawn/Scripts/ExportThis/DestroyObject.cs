using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public GameObject InsertSphere;
    private bool keyHit = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            keyHit = true;
        }
        if (keyHit == true)
        {
            Destroy(gameObject);
        }
     }
}
