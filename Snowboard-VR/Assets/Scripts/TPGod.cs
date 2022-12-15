using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPGod : MonoBehaviour
{
    public GameObject player;
    public GameObject visor;
 
    public void named()
    {
        Debug.Log("Boton God");
        player.transform.position = visor.transform.position;
        player.transform.rotation = visor.transform.rotation;
        GameObject.FindGameObjectWithTag("DropBall").GetComponent<DropTouch2>().enabled = true;
    }
}
