using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    //public GameObject Panel;
    //private TouchController TControl;

    void Update()
    {
        if (Input.touchCount == 3)
        {
            Debug.Log("Touched cancel");
            GameObject.FindGameObjectWithTag("DropBall").GetComponent<DropTouch2>().enabled = true;
            
         }
    }
}
