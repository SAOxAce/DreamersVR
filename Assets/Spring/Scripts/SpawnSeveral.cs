using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSeveral : MonoBehaviour {

    public GameObject sObj1;
    public GameObject sObj2;
    public GameObject sObj3;
    /*public GameObject sObj4;
    public GameObject sObj5;
    public GameObject objNext;
    */
    public Transform spawnPos1;
    public Transform spawnPos2;
    public Transform spawnPos3;
   /*public Transform spawnPos4;
    public Transform spawnPos5;
    */
    bool nextExists = true;
    int countClicks = 0;

    // Update is called once per frame
    void Update()
    {
        while (nextExists)
        {
            if (Input.GetMouseButton(0))
            {
                countClicks++;
            }

            switch (countClicks)
            {
                case 1:
                    {
                        Instantiate(sObj1, spawnPos1.position, spawnPos1.rotation);
                        break;
                    }
                case 2:
                    {
                        Instantiate(sObj2, spawnPos2.position, spawnPos2.rotation);
                        break;
                    }
                case 3:
                    {
                        Instantiate(sObj3, spawnPos3.position, spawnPos3.rotation);
                        nextExists = false;
                        break;
                    }
                /*case 4:
                    {
                        Instantiate(sObj4, spawnPos4.position, spawnPos4.rotation);
                        break;
                    }
                case 5:
                    {
                        Instantiate(sObj5, spawnPos5.position, spawnPos5.rotation);
                        nextExists = false;
                        break;
                    }
                    */

            }
        }
       // Destroy(objNext);

    }
}
