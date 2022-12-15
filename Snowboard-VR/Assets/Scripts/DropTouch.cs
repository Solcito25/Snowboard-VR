using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTouch : MonoBehaviour
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
        if (!touched && Input.touchCount > 0)
        {
            touched = true;
            UnityEngine.Touch touch = Input.GetTouch(0);

            Vector3 movement = new Vector3(touch.position.x, 100f, touch.position.y);
            Debug.Log("Touch Position : " + touch.position);
            Instantiate(objeto, target.transform.position + movement, target.transform.rotation);
        }
        if (Input.touchCount == 0)
        {
            touched = false;
        }
        //Static TD pos-------------------------
        /* if (!touched && Input.touchCount > 0)
         {
             touched = true;
             UnityEngine.Touch touch = Input.GetTouch(0);

             Vector3 movement = new Vector3(touch.position.x, 100f,touch.position.y);
             //Debug.Log("Touch Position : " + touch.position);
             Instantiate(objeto, target.transform.position + movement, target.transform.rotation);
         }
         if (Input.touchCount == 0)
         {
             touched = false;
         }
        */

    }
}
