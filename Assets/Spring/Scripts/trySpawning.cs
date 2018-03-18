using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trySpawning : MonoBehaviour {

    //public GameObject obj1;
    //public GameObject obj2;
    // public GameObject obj3;

    public Transform spawnPos;
    public GameObject spawnee;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
    }
}
