using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_control : MonoBehaviour
{
    public GameObject Player_spot;
    public GameObject Mountain_spot;
    //int Change;
    // Start is called before the first frame update
    void Start()
    {
      //  Change = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) { 
            Debug.Log("Algo");
            Player_spot.transform.position = Mountain_spot.transform.position;
            Player_spot.transform.rotation = Mountain_spot.transform.rotation;
            //Player_spot.transform.scale = Mountain_spot.transform.scale;
        }
        //if (Change == 1)
        //  Player_spot.transform.position = Mountain_spot.transform.position;
        //else
        //{
        //  Mountain_spot.transform.position = Player_spot.transform.position;
        // }
        /*if (OVRInput.Get(OVRInput.RawButton.Y))
        {
            model.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            print("Algo");
         //   SceneManager.LoadScene("name");
        }
        else
        {
            model.GetComponent<Renderer>().material.color = new Color(255, 255, 255);
            print("Algo");
          //  SceneManager.LoadScene("name11");
        }*/
    }
}
