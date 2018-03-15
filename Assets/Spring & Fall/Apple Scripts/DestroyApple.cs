using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyApple : MonoBehaviour {

    public GameObject apple;

    public void DestroyObject()
    {
       Destroy(apple);
      
    }
}
