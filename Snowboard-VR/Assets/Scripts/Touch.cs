using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject target;
    public GameObject objeto;
    private bool touched;
    void Start()
    {
        touched = false;
    }

    void Update()
    {

        //Debug.Log(Screen.width + "+" + Screen.height);
        if (!touched && Input.touchCount > 0)
        {
            touched = true;
            UnityEngine.Touch touch = Input.GetTouch(0);

            Debug.Log("Touch Position : " + touch.position);
        }
        if (Input.touchCount == 0)
        {
            touched = false;
        }

    }
}
