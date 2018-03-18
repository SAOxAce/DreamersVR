using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDestroy : MonoBehaviour
{
    public GameObject ObjectName;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
                if (hit.collider != null)
                {
                    ///tag name (erBridge)////
                    if (hit.collider.tag == "erBridge")
                    {
                        Destroy(ObjectName);
                    }
                }
        }
    }
}
